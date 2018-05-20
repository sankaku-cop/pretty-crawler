using System;
using System.Collections.Generic;

namespace PrettyCrawler.Crawler
{
    public interface ICrawler
    {
        IEnumerable<string> Crawl(Uri rootUri, Uri targetUri);
    }
}
