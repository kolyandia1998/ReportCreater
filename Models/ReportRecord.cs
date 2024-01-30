using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreater.Models
{
    public struct ReportRecord
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly ExpDate { get; set; }
        public string Phone { get; set; }
        public long Pan { get; set; }

        public ReportRecord(int userID, string firstName, string lastName, DateOnly expDate, string phone, long pan)
        {

            UserId = userID;
            FirstName = firstName;
            LastName = lastName;
            ExpDate = expDate;
            Phone = phone;
            Pan = pan;
        }
    }
}
