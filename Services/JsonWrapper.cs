using ReportCreater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportCreater.Services
{
    public class JsonWrapper
    {
        public IEnumerable<ReportRecord> Records { get; set; }
    }
}
