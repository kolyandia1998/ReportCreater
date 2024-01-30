using System;
using ReportCreater.Models;
using ReportCreater.Models.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReportCreater.Services.Parsers
{
    public class XmlParser : BaseParser<Card>
    {
        public override IEnumerable<Card>? Parse(string path)
        {
            XDocument xdoc = XDocument.Load(path);
            var xml = xdoc.Element("Cards")?.Elements("Card")
                        .Select(e => CardDTO.FromXml(e.Attribute("UserId")?.Value, e.Element("Pan")?.Value, e.Element("ExpDate")?.Value))
                        .Where(c => c != null);
            if (xml != null && xml.Count() > 0)
                return xml;
            return null;
        }
    }
}
