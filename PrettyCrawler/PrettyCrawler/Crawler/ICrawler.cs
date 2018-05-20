using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrettyCrawler.Crawler
{
    public interface ICrawler
    {
        Task<IEnumerable<string>> CrawlAsync(string rootUrl);
    }
}
