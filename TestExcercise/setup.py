#!/usr/bin/env python

import setuptools

with open("README.md","r") as file:
	long_description = file.read()

setuptools.setup(
	name='py-contacts',
	py_modules = ['py-contacts'],
	description='Contact Directory Program',
	author='Talhah Raza Kazi',
	long_description = long_description,
	author_email='talha_kazi3@hotmial.com',
	url='https://github.com/talhahkazi93/projects/tree/master/TestExcercise',
    )