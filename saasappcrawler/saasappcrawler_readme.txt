=> Purpose

Scrapy web crawler to get possible saas urls (based on special keywords), provided a seed url as input.

=> Custom Module Dependencies

None

=> Usage

Run this crawler from spiders directory as follows:

$ scrapy runspider saas_crawler.py \
-a start_urls=<"http://example.net"> \
-a domain=<"example.net"> \
-s JOBDIR=crawls/<example>

==> Steps Performed

1) Crawler takes input a seed url and crawls the urls (as per settings defined in settings.py)

2) scrapes the visited urls that have special keywords (defined by 'key_words' list) in the body of the page or in the url itself. 
    
3) Creates a json file for the scraped urls after every 'max_count=2' count and at the spider closure event

4) At spider closure event, creates a csv file with specified format (to be used by nascent ticket creation script 'service_for_ticket_creation_in_nascent.py' process) 

5) Copy the csv file to specified path (<HOME_env_var> + "/jsons/saas_crawler"). If the path doesn't exist initially, create it.

==> Output Files

1) "saas_crawler_" + <input_domain> + ".json" (i.e. created after intervals & at closure)
2) "saas_crawler_" + <input_domain>  + "_saas_apps_discovery.csv" (created at closure & copied to specified path)
3) <input_domain> + "_url.csv" (can be removed - created/updated after every url scraped)
4) <input_domain> + "_body.csv" (can be removed - created/updated after every url scraped)

==> Notes

Following scrapy files that reside in the folder & can be used in future:
1) pipelines.py 
2) items.py 