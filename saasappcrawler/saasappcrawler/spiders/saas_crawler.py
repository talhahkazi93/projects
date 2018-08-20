""" Crawler that takes seed url as input 
    and scrapes urls that have special keywords in the body of the page 
    or in url itself. 
    Creates a file for the scraped urls which is then copied to specified path

Usage:
    Run this crawler from spiders directory as follows:

  $ scrapy runspider saas_crawler.py
    -a start_urls=<"http://example.net">
    -a domain=<"example.net">
    -s JOBDIR=crawls/<example>
"""

import sys, csv, json, os
import errno, logging
import scrapy
from scrapy.spiders import CrawlSpider, Rule
from scrapy.linkextractors.lxmlhtml import LxmlLinkExtractor
from saaswebcrawler.items import SaaswebcrawlerItem
from scrapy.exceptions import DropItem
from scrapy.selector import Selector
from scrapy.xlib.pydispatch import dispatcher
from scrapy import signals
from shutil import copy

class FileIO(file): 
    #subclass file to have a more convenient use of writeline
    def __init__(self, name, mode = 'r'):
        self = file.__init__(self, name, mode)

    def write_lines(self, string):
        self.writelines(str(string) + '\n')

class WebCrawlerForSaaSDiscovery(CrawlSpider):    
    name = 'saaswebcrawler'

    def __init__(self, *args, **kwargs):
        super(WebCrawlerForSaaSDiscovery, self).__init__(*args, **kwargs)

        self.url_list = []
        self.key_words = [
        'login'
        ,'signin'
        ,'sign_in'
        ,'sign-in'
        ,'register'
        ,'signup'
        ,'sign_up'
        ,'sign-up'
        ,'logon'
        ,'log-on'
        ,'log_on'
        ]
        self.start_urls = [kwargs.get('start_urls')]
        self.domain = kwargs.get('domain')
        self.source = "saas_crawler_" + self.domain
        self.crawled_domain_file = self.source + ".json"
        self.csv_file_name = self.source + "_saas_apps_discovery.csv"
        self.url_file = self.domain + "_url.csv"
        self.body_file = self.domain + "_body.csv"
        self.count = 0 
        self.max_count = 2
        self.saas_urls = {}
        dispatcher.connect(self.spider_closed, signals.spider_closed)
        logging.debug("Crawling initiating point is defined as: %s" %self.start_urls)

    rules = (Rule(LxmlLinkExtractor(allow=()), callback='parse_url', follow=True),)    
    logging.basicConfig(filename='/var/log/saaswebcrawler_spider_info.log', level=logging.DEBUG, format='%(asctime)s %(message)s')
    logging.basicConfig(filename='/var/log/saaswebcrawler_spider_error.log', level=logging.ERROR, format='%(asctime)s %(message)s')
   
    def mkdir_p(self, path):
    
        try:
            logging.debug("Creating the path: '%s'"%path)
            os.makedirs(path)
        except OSError as exc:
            if exc.errno == errno.EEXIST and os.path.isdir(path):
                pass
            else:
                raise

    def create_json(self, file_name, file_data):

        fileptr = open(file_name,'w')
        json.dump(file_data, fileptr, indent=4)
        fileptr.close()
        logging.debug("***** Dumped data to json file!")

    def copy_file(self, filename):

        logging.debug("***** Copying file!")
        if not os.path.exists(filename):
            logging.debug("File '%s' does not exit"%filename)
            return

        home_dir = os.getenv('HOME', "")
        if not os.path.exists(home_dir):
            logging.debug("Path for 'HOME' variable doesn't exist.")
            return

        saas_dir = home_dir + "/jsons/saas_crawler"
        if not os.path.exists(saas_dir):
            self.mkdir_p(saas_dir)
        copy(filename, saas_dir)
        logging.debug("File copied to directory: %s"%saas_dir)

    def create_csv(self, filename):

        logging.debug("***** Creating csv: '%s'"%filename)
        try:
            with open(filename, "w") as saas_urls_csv:
                csv_file = csv.writer(saas_urls_csv, delimiter='|')
                csv_file.writerow(['Public Website URL']+['Source'])
                for url in self.saas_urls:
                    source = self.saas_urls[url]
                    csv_file.writerow([url]+[source]) 
                logging.debug("Converted json to csv!")
        except Exception, e:
            logging.error("Some error occurred while creating csv from json: %s"%(repr(e)))
       
    def parse_url(self, response):
       
        try:
            #item = SaaswebcrawlerItem()
            sel = Selector(response)
            #item['url'] = response.url
            current_url = response.url
            logging.debug("Item received as %s" %current_url)
            final_url = current_url.split('?',1)
            text_list = (sel.xpath("//body//text()").extract())
            complete_text = " ".join(text_list)
           
            if any(keyword in current_url.lower() for keyword in self.key_words):
                logging.debug("Found URL through the crawler for domain: '%s'" %self.domain)
                logging.debug("**** Found keyword in URL: '%s'" %current_url)                
                if any(final_url[0] in urllist for urllist in self.url_list):
                    logging.debug("Duplicate URL in 'found_url' list. Dropping the URL %s" %final_url[0])
                    raise DropItem()
                else:     
                    self.count += 1               
                    self.url_list.append(final_url[0])  
                    tempfile = FileIO(self.url_file, 'a')
                    tempfile.write_lines(final_url[0]) 
                    self.saas_urls[final_url[0]] = self.source

            elif any(keyword in complete_text for keyword in self.key_words):
                logging.debug("Found URL through the crawler for domain: '%s'" %self.domain)
                logging.debug("**** Found keyword in the body of the url '%s'" %final_url[0])                
                if any(final_url[0] in urllist for urllist in self.url_list):
                    logging.debug("Duplicate URL in 'found_url' list. Dropping the URL %s" %final_url[0])
                    raise DropItem()
                else:    
                    self.count += 1                
                    self.url_list.append(final_url[0])
                    tempfile = FileIO(self.body_file, 'a')
                    tempfile.write_lines(final_url[0])  
                    self.saas_urls[final_url[0]] = self.source                  
            #return item 
            
            if self.count == self.max_count:
                self.create_json(self.crawled_domain_file, self.saas_urls)
                self.count = 0

        except Exception, e:            
            logging.error("Exception raised: %s" %(repr(e)))

    def spider_closed(self, spider):
        
        logging.debug("***** Closing spider: '%s'"%spider.name)
        self.create_json(self.crawled_domain_file, self.saas_urls)
        if self.saas_urls:
            self.create_csv(self.csv_file_name)
            self.copy_file(self.csv_file_name)
        else:
            logging.debug("No Urls extracted")
        logging.debug("***** Spider closed *****")