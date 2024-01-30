using ReportCreater.Models;

namespace ReportCreater.Services.Interfaces
{
    public interface IGenerator
    {
        void Generate(IEnumerable<ReportRecord> values, string path);
    }
}
