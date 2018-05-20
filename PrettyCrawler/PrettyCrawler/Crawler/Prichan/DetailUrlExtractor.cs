using System.Collections.Generic;
using System.Linq;

using HtmlAgilityPack;

namespace PrettyCrawler.Crawler.Prichan
{
    public class DetailUrlExtractor
    {
        /// <summary>
        /// 引数のページに紐づくチケット詳細Urlの一覧を返す
        /// </summary>
        /// <param name="htmlText">root html text</param>
        /// <returns>detail urls</returns>
        public IEnumerable<string> Extract(string htmlText)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(htmlText);

            return doc.DocumentNode.SelectNodes(@"//a")
                .Select(node => node.GetAttributeValue("href", string.Empty))
                .Where(url => url.StartsWith("details/"));
        }
    }
}
