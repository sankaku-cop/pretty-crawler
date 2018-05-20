using System.Linq;

using Xunit;

namespace PrettyCrawler.Crawler.Prichan
{
    public class DetailUrlExtractorTest
    {
        [Theory]
        [InlineData("<a href='hoge.html'>", null)]
        [InlineData("<a href='details/hoge.html'>", "details/hoge.html")]
        public void ExtractTest(string src, string expected)
        {
            var extractor = this.Create();
            Assert.True(Equals(extractor.Extract(src).FirstOrDefault(), expected));
        }

        private DetailUrlExtractor Create()
        {
            return new DetailUrlExtractor();
        }
    }
}