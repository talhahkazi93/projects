#!/usr/bin/python3
import json
import time
import traceback
import random
import socket
import argparse
import threading
import signal
import sys

import requests

OFFLINE = False


def signalhandler(sn, sf):
    send_command_request('{"type": "done"}')
    sys.exit(0)


def send_command_request(request):
    print("request:", request)
    if not OFFLINE:
        requests.post(command_addr, data={"REQUEST": request})


def guess_account_name(account_name):
    send_command_request(
        '{"type": "learned","variable": "account","secret": "' + account_name + '"}')




if __name__ == '__main__':
    signal.signal(signal.SIGTERM, signalhandler)
    signal.signal(signal.SIGINT, signalhandler)
    parser = argparse.ArgumentParser(description='Proxy')
    parser.add_argument('-p', type=int, default=4000, help="listen port")
    parser.add_argument('-s', type=str, default="127.0.0.1", help="server ip address")
    parser.add_argument('-q', type=int, default=3000, help="server port")
    parser.add_argument('-c', type=str, default="127.0.0.1", help="command server")
    parser.add_argument('-d', type=int, default=5000, help="command port")
    args = parser.parse_args()
    print('started')
    sys.stdout.flush()
    command_port = args.d
    command_ip = args.c
    command_addr = "http://" + command_ip + ":" + str(command_port)
    fake_bank_port = "6123"
    send_command_request(
        '{"type": "input","input":{"input": ["-p","' + fake_bank_port +
        '","-i","%IP%","-a","%ACCOUNT%","-n", "%AMOUNT%", "-s", "fake.auth"],"base64": false}}')
    # send_command_request(
    #     '{"type": "input","input":{"input": ["-p","%PORT%","-i","%IP%","-ated","-d2.00"],"base64": false}}')
    try:
        print("waiting...")
        time.sleep(15.0)
        secret_account = open("secret_account.txt").read()
        print("guessing...")
        guess_account_name(secret_account)
    except Exception as e:
        print(e)
    send_command_request('{"type": "done"}')
