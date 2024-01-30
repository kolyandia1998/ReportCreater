using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreater.Models.DTO
{
    public static class UserDTO
    {
        public static User? FromCsv(string[] fields)
        {
            if (fields.Count() < 4)
                return null;
            var user = new User();

            if (!int.TryParse(fields[0], out var idRes))
                return null;
            user.UserId = idRes;
            user.Name = fields[1];
            user.SecondName = fields[2];
            user.Number = fields[3];
            return user;
        }
    }
}
