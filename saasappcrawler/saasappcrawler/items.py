import scrapy


class SaaswebcrawlerItem(scrapy.Item):    
    url = scrapy.Field()
    data = scrapy.Field()