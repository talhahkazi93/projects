__author__ = "Talhah Raza Kazi(talha_kazi3@hotmail.com)"

import sys
import os
import argparse
import yaml

filename = "Contacts"

def load_file(filepath):
	#loads yaml file
	with open(filepath, "r") as file:
		data = yaml.load(file)
	return data

def write_file(filepath,data):
	with open(filepath, "w") as file:
		yaml.dump(data, file)

def add(name,email,number,filename):
	contact = {}
	contact[name] = {
		'Email': email,
		'Number' : number
	}

	if os.path.exists(filename):
		data = load_file(filename)
		data.update(contact)
		write_file(filename,data)
	else:
		write_file(filename,contact)

def show(name,filename):
	if os.path.exists(filename):
		contact = load_file(filename)

		if name in contact:
			print contact[name]
		else:
			print "Contact does not exists"

	else:
		print "file does not exists"

def argparser(arg):
	global filename

	if arg.email:
		email = arg.email[0]
	if arg.number:
		number = arg.number[0]

	if arg.add:
		name = arg.add[0]
		add(name,email,number,filename)
	elif arg.show:
		name = arg.show[0]
		show(name,filename)
	elif arg.list:
		contacts = load_file(filename)
		print contacts


def main():
	parser = argparse.ArgumentParser(description='Define the operation that needs to be done')
	parser.add_argument('--email',action='append',dest='email',help='Enter email')
	parser.add_argument('--number',action='append',dest='number',help='Enter Number')
	parser.add_argument('--add',action='append',dest='add',help='Add Contact')
	parser.add_argument('--show',action='append',dest='show',help='show Contact details')
	parser.add_argument('--list-',action='store_true',dest='list',help='List all Contacts')

	args = parser.parse_args()
	argparser(args)
	
if __name__ == '__main__':
	main()
