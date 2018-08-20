# Scrapy settings for saaswebcrawler project
#

BOT_NAME = 'saaswebcrawler'

SPIDER_MODULES = ['saaswebcrawler.spiders']
NEWSPIDER_MODULE = 'saaswebcrawler.spiders'

# For later use in multiple additions in the crawler
# ITEM_PIPELINES = {
#     #'myproject.pipelines.PricePipeline': 300,
#     'myproject.pipelines.JsonWriterPipeline': 800,
# }

# settings for making the spider crawl in breadth first order as needed.

DEPTH_PRIORITY = 1
SCHEDULER_DISK_QUEUE = 'scrapy.squeue.PickleFifoDiskQueue'
SCHEDULER_MEMORY_QUEUE = 'scrapy.squeue.FifoMemoryQueue'


# Optimization Setting for broad crawl
CONCURRENT_REQUESTS = 30
#LOG_LEVEL = 'INFO'
COOKIES_ENABLED = False
RETRY_ENABLED = True
RETRY_TIMES = 2
DOWNLOAD_TIMEOUT = 60
#REDIRECT_ENABLED = True
AJAXCRAWL_ENABLED = True
REACTOR_THREADPOOL_MAXSIZE = 10
REDIRECT_MAX_TIMES = 2
#URLLENGTH_LIMIT = 2083 #limits the URL length to crawl

# Crawl responsibly by identifying yourself (and your website) on the user-agent
USER_AGENT = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/27.0.1453.93 Safari/537.36"

# The amount of time (in secs) that the downloader should wait
# before downloading consecutive pages from the same website. 
# 3 seconds corresponds to roughly 20 request/sec maximum
# Default value is 0 so the downloader will ask for pages as fast as it can
# within the constraints of CONCURRENT_REQUESTS_PER_DOMAIN
DOWNLOAD_DELAY=1
CONCURRENT_REQUESTS_PER_DOMAIN=8
DEPTH_LIMIT=0
DEPTH_STATS=True

# Enables the AutoThrottle extension. (Default: False)
# See http://doc.scrapy.org/en/latest/topics/autothrottle.html
AUTOTHROTTLE_ENABLED=True
# The initial download delay (in seconds). Default: 60.0 (Default: 5.0)
AUTOTHROTTLE_START_DELAY=5
# The maximum download delay (in seconds) to be set in case of high latencies.
AUTOTHROTTLE_MAX_DELAY=60
AUTOTHROTTLE_DEBUG=False