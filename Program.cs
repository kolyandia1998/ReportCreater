using ReportCreater.Services;
using ReportCreater.Services.Interfaces;
using ReportCreater.Services.Parsers;
using System.Text;



namespace ReportCreater
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var CsvParser = new CsvParser();
            var XmlParser = new XmlParser();
            IGenerator generator = new JsonGenerator();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow(XmlParser,CsvParser,generator));
        }
    }
}