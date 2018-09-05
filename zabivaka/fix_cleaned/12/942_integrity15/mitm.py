#!/usr/bin/env python2
import json
import traceback
import random
from socket import socket, AF_INET, SOCK_STREAM, timeout, SO_REUSEADDR, SOL_SOCKET
import argparse
import threading
import signal
import sys
import string
from contextlib import contextmanager

running = True
verbose = True
res = ""
getReq = ""
CLIENT2SERVER = 1
SERVER2CLIENT = 2
receivedmessage = []
count=0
def mitm(buff, direction):
  hb = buff
  #print("In mitm fx:   " + str(hb))
  if direction == CLIENT2SERVER:
    #print("Client to Server:   " + str(hb) + "   : type: " + type(hb))
    pass


  elif direction == SERVER2CLIENT:
      #print("Server to Client:   " + str(hb) + "   : type: " + type(hb))
      pass

  return hb

@contextmanager
def ignored(*exceptions):
  try:
    yield
  except exceptions:
    pass 

def killpn( a, b, n):
  if n != CLIENT2SERVER:
    killp( a, b)

def killp(a, b):
  with ignored(Exception):
    a.shutdown(socket.SHUT_RDWR)
    a.close()
    b.shutdown(socket.SHUT_RDWR)
    b.close()
  return

def worker(client, server, n):
  while running == True:
    global  receivedmessage
    fragments = []
    #b = ""
    with ignored(Exception):
      b = client.recv(1024)
      #print(type(b))
      #fragments.append(b)
      #message = b''.join(fragments)

      if len(b) != 0:
        #print("Message inside Worker: " + b)
        receivedmessage.append(b)

    if len(b) == 0:
      killpn(client,server,n)
      return
    try:
      b = mitm(b,n)

    except:
      pass
    try:
      if b != None:
        server.send(b)

    except:
      killpn(client,server,n)
      return
  killp(client,server)
  return

def signalhandler(sn, sf):
  running = False

def doProxyMain(port, remotehost, remoteport):
  signal.signal(signal.SIGTERM, signalhandler)
  global count
  count = 0
  global getReq
  global receivedmessage
  global res
  try:
    s = socket(AF_INET, SOCK_STREAM)
    s.setsockopt(SOL_SOCKET, SO_REUSEADDR, 1)
    s.bind(("0.0.0.0", port))
    s.listen(1)
    workers = []
    while running == True:
      if count >= 3:
        break
      k,a = s.accept()
      count=count+1

      v = socket(AF_INET, SOCK_STREAM)
      v.connect((remotehost, remoteport))
      t1 = threading.Thread(target=worker, args=(k,v,CLIENT2SERVER))        #k=atm , v = bank
      t2 = threading.Thread(target=worker, args=(v,k,SERVER2CLIENT))
      t2.start()
      t1.start()
      workers.append((t1, t2, k, v))
  except KeyboardInterrupt:
    signalhandler(None, None)
  for t1,t2,k,v in workers:
    killp(k,v)
    t1.join()
    t2.join()
  #print("Outside the first infinite while loop:")
  #print("Withdrawl Request: " + str(receivedmessage[2]))
  getReq =receivedmessage[3]
  #print(getReq)
  s = socket(AF_INET, SOCK_STREAM)
  s.setsockopt(SOL_SOCKET, SO_REUSEADDR, 1)
  s.bind(("0.0.0.0", port))
  s.listen(1)
  k, a = s.accept()
  newget = k.recv(1024)
  sock = socket(AF_INET, SOCK_STREAM)
  sock.setsockopt(SOL_SOCKET, SO_REUSEADDR, 1)
  sock.connect((args.s, args.q))
  #print("Connected")
  sock.sendall(newget)
  received = sock.recv(1024).strip()
  k.sendall(getReq)
  s = socket(AF_INET, SOCK_STREAM)
  s.setsockopt(SOL_SOCKET, SO_REUSEADDR, 1)
  s.bind(("0.0.0.0", port))
  s.listen(1)
  workers = []
  while running == True:
      k, a = s.accept()
      v = socket(AF_INET, SOCK_STREAM)
      v.connect((remotehost, remoteport))
      t1 = threading.Thread(target=worker, args=(k, v, CLIENT2SERVER))
      t2 = threading.Thread(target=worker, args=(v, k, SERVER2CLIENT))
      t2.start()
      t1.start()
      workers.append((t1, t2, k, v))


  for t1, t2, k, v in workers:
    killp(k, v)
    t1.join()
    t2.join()


  return

if __name__ == '__main__':
  parser = argparse.ArgumentParser(description='Proxy')
  parser.add_argument('-p', type=int, default=4000, help="listen port")
  parser.add_argument('-s', type=str, default="127.0.0.1", help="server ip address")
  parser.add_argument('-q', type=int, default=3000, help="server port")
  parser.add_argument('-c', type=str, default="127.0.0.1", help="command server")
  parser.add_argument('-d', type=int, default=5000, help="command port")
  args = parser.parse_args()
  print('started')
  sys.stdout.flush()
  doProxyMain(args.p, args.s, args.q)

