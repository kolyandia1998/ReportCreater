using Newtonsoft.Json;
using ReportCreater.Models;
using ReportCreater.Services.Interfaces;

namespace ReportCreater.Services
{
    internal class JsonGenerator : IGenerator
    {
        public void Generate(IEnumerable<ReportRecord> mergeData, string path)
        {
            var json = JsonConvert.SerializeObject(mergeData);
            File.WriteAllText(path, json);
        }
    }
}
