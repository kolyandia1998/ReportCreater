using Newtonsoft.Json;
using ReportCreater.Models;
using ReportCreater.Services.Interfaces;

namespace ReportCreater.Services
{
    public class JsonGenerator : IGenerator
    {
        public void Generate(IEnumerable<ReportRecord> records, string path)
        {
            var wrapper = new JsonWrapper { Records = records };
            var json = JsonConvert.SerializeObject(wrapper);
            File.WriteAllText(path, json);
        }
    }
}
