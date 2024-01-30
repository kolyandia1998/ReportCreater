
using Microsoft.VisualBasic.FileIO;
using ReportCreater.Models;
using ReportCreater.Models.DTO;


namespace ReportCreater.Services.Parsers
{
    public class CsvParser : BaseParser<User>
    {
        public override IEnumerable<User>? Parse(string path)
        {
            List<User> result = new List<User>();
            using var textFieldParser = new TextFieldParser(path);
            textFieldParser.SetDelimiters(";");
            textFieldParser.TextFieldType = FieldType.Delimited;

            while (!textFieldParser.EndOfData)
            {
                var fileds = textFieldParser.ReadFields();
                if (fileds == null)
                    continue;
                var user = UserDTO.FromCsv(fileds);
                if (user == null)
                    continue;
                result.Add(user);
            }
            if (result.Where(u => u != null).Count() == 0)
                return null;
            return result.Where(u => u != null);
        }

    }
}
