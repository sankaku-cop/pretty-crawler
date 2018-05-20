using PrettyCrawler.Ticket;

namespace PrettyCrawler.Converter
{
    public interface ITicketConverter
    {
        ITicket Convert(string html);
    }
}
