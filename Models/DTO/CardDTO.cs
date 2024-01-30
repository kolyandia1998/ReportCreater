using System.Globalization;

namespace ReportCreater.Models.DTO
{
    public static class CardDTO
    {
        public static Card? FromXml(string? userId, string? pan, string? expDate)
        {
            Card card = new Card();
            if ( !int.TryParse(userId, out var idRes) )
                return null;
            card.UserID = idRes;
            if ( !long.TryParse(pan, out var panRes) )
                return null;
            card.Pan = panRes;
            if ( !DateOnly.TryParseExact(expDate, "dd/MM/yyyy", null, DateTimeStyles.None, out var expDateRes) )
                return null;
            card.ExpDate = expDateRes;
            return card;
        }
    }
}
