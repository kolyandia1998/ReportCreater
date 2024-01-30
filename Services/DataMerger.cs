using ReportCreater.Models;
namespace ReportCreater.Services
{
    public static class DataMerger
    {
        public static IEnumerable<ReportRecord>? MergeData(IEnumerable<User> userSource, IEnumerable<Card> cardSource)
        {
            if ( userSource == null || cardSource == null )
                return null;
            var records = cardSource.Join(userSource, c => c.UserID, u => u.UserId, (c, u) => new ReportRecord(u.UserId, u.Name, u.SecondName, c.ExpDate, u.Number, c.Pan));
            if ( records.Count() == 0 )
                return null;
            return records;
        }
    }
}
