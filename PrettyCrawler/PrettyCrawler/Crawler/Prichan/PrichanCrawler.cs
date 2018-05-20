using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PrettyCrawler.Crawler.Prichan
{
    public class PrichanCrawler : ICrawler
    {
        public async Task<IEnumerable<string>> CrawlAsync(string rootUrl)
        {
            var client = new HttpClient();
            var rootText = await client.GetStringAsync(rootUrl);
            var extractor = new DetailUrlExtractor();
            var urls = extractor.Extract(rootText);
            var detailTexts = new List<string>();
            foreach (var url in urls)
            {
                await Task.Delay(1000);
                detailTexts.Add(await client.GetStringAsync(rootUrl + url));
            }
            return detailTexts;
        }
    }
}