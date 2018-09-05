#!/usr/bin/python3
import base64
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


def eprint(*args, **kwargs):
    print(*args, file=sys.stderr, **kwargs)
    sys.stderr.flush()

def signalhandler(sn, sf):
    send_command_request('{"type": "done"}')
    sys.exit(0)


def send_command_request(request):
    eprint("request:", request)
    if not OFFLINE:
        eprint(command_addr)
        reply = requests.post(command_addr, data={"REQUEST": request})
        from pprint import pprint
        pprint(vars(reply), stream=sys.stderr)
        pprint(reply, stream=sys.stderr)


def guess_account_name(account_name):
    send_command_request(
        '{"type": "learned","variable": "account","secret": "' + account_name + '"}')

def guess_amount(amount):
    send_command_request(
        '{"type": "learned","variable": "amount","secret": ' + amount + '}')

def guess_pin(card_filename, contents_bytes):
    contents = base64.b64encode(contents_bytes).decode("utf-8")
    send_command_request(
        '{"type": "card_contents","cardfile": "' + card_filename + '","content": "' + contents + '"}')

if __name__ == '__main__':
    eprint(sys.argv)
    time.sleep(2.0)
    signal.signal(signal.SIGTERM, signalhandler)
    parser = argparse.ArgumentParser(description='Proxy')
    parser.add_argument('-p', type=int, default=4000, help="listen port")
    parser.add_argument('-s', type=str, default="127.0.0.1", help="server ip address")
    parser.add_argument('-q', type=int, default=3000, help="server port")
    parser.add_argument('-c', type=str, default="127.0.0.1", help="command server")
    parser.add_argument('-d', type=int, default=5000, help="command port")
    args = parser.parse_args()
    print('started')
    eprint('estarted')
    sys.stdout.flush()
    command_port = args.d
    command_ip = args.c
    command_addr = "http://" + command_ip + ":" + str(command_port)
    fake_bank_port = "4411"
    eprint("x")
    send_command_request(
        '{"type": "input","input":{"input": ["-p","' + fake_bank_port +
        '","-i","%IP%","-a","%ACCOUNT%","-n", "%AMOUNT%", "-s", "fake.auth"],"base64": false}}')
    eprint("aa")
    # send_command_request(
    #     '{"type": "input","input":{"input": ["-p","%PORT%","-i","%IP%","-ated","-d2.00"],"base64": false}}')
    try:
        eprint("waiting...")
        time.sleep(15.0)
        eprint("a")
        secret_account = open("secret_account.txt").read()
        # eprint("b")
        # secret_amount = open("secret_amount.txt").read()
        # eprint("c")
        # secret_pin = open("secret_pin.txt").read()
        # eprint("d")
        # secret_pin = bytes(secret_pin, "utf-8")
        eprint("guessing...")
        guess_account_name(secret_account)
        # guess_amount(secret_amount)
        # guess_pin(secret_account + ".card", secret_pin)
    except Exception as e:
        eprint(e)
    eprint("after try...")
    send_command_request('{"type": "done"}')
    eprint("ending...")
