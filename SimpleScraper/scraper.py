from urllib2 import urlopen
from bs4 import BeautifulSoup
import xlsxwriter

def Parse_player(data,html):
	# soup1 = BeautifulSoup(html,"lxml")
	base_url = "https://www.pro-football-reference.com"
	ele = html.select('a')
	hrefs = ele[0]['href']
	url = base_url+hrefs
	print url
	soup1 = BeautifulSoup(urlopen(url).read(),'lxml')
	try:
		table1 = soup1('table',{'id':"receiving_and_rushing"})[0].find_all('tr')
		name = data + ' receicing & rushing'
		worksheet1 = workbook.add_worksheet(name)
		row_num = 0
		for rows in table1:
			col = rows.findChildren(recursive=False)
			col_num = 0
			for elements in col:
				if 'th' in str(elements):
					data = elements.text.strip()
					cell_format = workbook.add_format({'bold':True})
					worksheet1.write(row_num,col_num,data,cell_format)
					col_num += 1
				elif 'td' in str(elements):
					data = elements.text.strip()
					worksheet1.write(row_num,col_num,data)
					col_num += 1
			row_num += 1
	except:
		print "table not found"
		return

	# ele = soup.select('.left a')
	# for n in range(0,len(ele)):
	# 	hrefs = ele[n]['href']
	# 	url = base_url+hrefs
	# 	soup1 = BeautifulSoup(urlopen(url).read(),'lxml')

	# 	try:
	# 		table1 = soup1('table',{'id':"receiving_and_rushing"})[0].find_all('tr')
	# 		for rows in table1:
	# 			col = rows.findChildren(recursive=False)
	# 			col = [ele.text.strip() for ele in col]
	# 			print col
	# 	except:
	# 		print "table not found"
		

workbook = xlsxwriter.Workbook('Team_injuries.xlsx')

worksheet = workbook.add_worksheet('injuries')

url = "https://www.pro-football-reference.com/teams/rav/2015_injuries.htm"
soup = BeautifulSoup(urlopen(url).read(),'lxml')

table = soup('table',{"class":"sortable stats_table"})[0].find_all('tr')

# data = []
row_num = 0

for row in table:
	cols = row.findChildren(recursive=False)
	col_num = 0
	for elements in cols:
		if 'th' in str(elements):
			data = elements.text.strip()
			if not row_num == 0:
				print data
				Parse_player(data,elements)
			if row_num == 0:
				cell_format = workbook.add_format({'bold':True})
			else:
				cell_format = None
			worksheet.write(row_num,col_num,data,cell_format)
			col_num += 1
		elif 'td' in str(elements):
			# print elements.text.strip()
			data = elements.text.strip()
			if data == 'P':
				cell_format = workbook.add_format({'bold':True, 'bg_color': '#7cff5c'})
			elif data == 'D':
				cell_format = workbook.add_format({'bold':True, 'bg_color': '#ffbe5c'})
			elif data == 'O':
				cell_format = workbook.add_format({'bold':True, 'bg_color': '#ff5c5c'})
			elif data == 'IR':
				cell_format = workbook.add_format({'bold':True, 'bg_color': 'red'})
			elif data == 'Q':
				cell_format = workbook.add_format({'bold':True, 'bg_color': '#deff5c'})
			else:
				cell_format = None
			worksheet.write(row_num,col_num,data,cell_format)
			col_num += 1

	row_num += 1

	# cols = [ele.text.strip() for ele in cols]
	# data.append(cols)
	# worksheet.write(0,0,''.join(cols))

# worksheet.add_table('A1:Q47',{'data':data})

workbook.close()
