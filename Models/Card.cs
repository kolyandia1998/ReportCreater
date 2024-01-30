namespace ReportCreater.Models
{
    public class Card
    {
        public DateOnly ExpDate { get; set; }
        public long Pan { get; set; }
        public int UserID { get; set; }

        public Card(DateOnly expDate, long pan, int userID)
        {
            ExpDate = expDate;
            Pan = pan;
            UserID = userID;
        }
        public Card() { }
    }
}

