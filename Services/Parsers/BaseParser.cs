using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreater.Services.Parsers
{
    public abstract class BaseParser<T>
    {
        public abstract IEnumerable<T>? Parse(string path);
    }
}
