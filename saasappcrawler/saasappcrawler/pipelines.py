from scrapy.exceptions import DropItem
import json

class JsonWriterPipeline(object):

    def __init__(self):
        self.file = open('items.jl', 'wb')

    def process_item(self, item, spider):
        line = json.dumps(dict(item)) + "\n"
        self.file.write(line)
        return item
class SaaswebcrawlerPipeline(object):
    def process_item(self, item, spider):
        return item
