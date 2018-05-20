using PrettyCrawler.Ticket;

namespace PrettyCrawler.Converter
{
    /// <summary>
    /// Json形式のstringに変換
    /// </summary>
    public interface IJsonConverter
    {
        string Convert(ITicket ticket);
    }
}
