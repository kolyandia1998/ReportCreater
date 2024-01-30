namespace ReportCreater.Services.Parsers
{
    public abstract class BaseParser<T>
    {
        public abstract IEnumerable<T>? Parse(string path);
    }
}
