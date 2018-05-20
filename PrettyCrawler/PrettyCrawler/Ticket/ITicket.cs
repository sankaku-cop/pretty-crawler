namespace PrettyCrawler.Ticket
{
    public interface ITicket
    {
        /// <summary>
        /// アイテムID
        /// </summary>
        string ItemId { get; }

        /// <summary>
        /// チケットID
        /// </summary>
        string TicketId { get; }

        /// <summary>
        /// コーデ名
        /// </summary>
        string Name { get; }

        /// <summary>
        /// カテゴリ
        /// </summary>
        Category Category { get; }

        /// <summary>
        /// カラー
        /// </summary>
        string Color { get; }

        /// <summary>
        /// ブランド
        /// </summary>
        string Brand { get; }

        /// <summary>
        /// ジャンル
        /// </summary>
        string Genre { get; }
    }
}
