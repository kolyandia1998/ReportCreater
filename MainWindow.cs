using ReportCreater.Models;
using ReportCreater.Services;
using ReportCreater.Services.Interfaces;
using ReportCreater.Services.Parsers;

namespace ReportCreater
{
    public partial class MainWindow : Form
    {
        private static int reportCounter = 0;
        private string _selectedDirectory;
        private string _outPutDirectory;
        private XmlParser _xmlParser;
        private CsvParser _csvParser;
        private IGenerator _generator;
        private Queue<IEnumerable<ReportRecord>> _reportQueue = new Queue<IEnumerable<ReportRecord>>();

        public MainWindow(XmlParser xmlParser, CsvParser csvParser, IGenerator generator)
        {
            _xmlParser = xmlParser;
            _csvParser = csvParser;
            _generator = generator;
            InitializeComponent();
        }

        private void _reportGeneratorButton_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(_outPutDirectory) )
            {
                _messageTextBox.Text = "Не выбрана выходная директория";
                return;
            }
            if ( _reportQueue.Count > 0 )
            {
                _generator.Generate(_reportQueue.Dequeue(), _outPutDirectory + $"/{reportCounter}.json");
                if ( _reportQueue.Count > 0 )
                    _messageTextBox.Text = $"Можно сгенерировать отчёт. Будет создано: {_reportQueue.Peek().Count()} строк";
                else
                    _messageTextBox.Text = "Нет отчётов для генерации";
            }
        }

        private void _directorySelectionButton_Click(object sender, EventArgs e)
        {
            if ( _folderBrowserDialog.ShowDialog() == DialogResult.OK )
            {
                _selectedDirectory = _folderBrowserDialog.SelectedPath;
                _selectedDirectoryTextBox.Text = _selectedDirectory;
                _fileSystemWatcher.Path = _selectedDirectory;
            }
        }

        private void _fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            var xmlFiles = Directory.GetFiles(_selectedDirectory, "*.xml");
            var csvFiles = Directory.GetFiles(_selectedDirectory, "*.csv");
            if ( xmlFiles.Count() == 0 || csvFiles.Count() == 0 )
                return;
            foreach ( var xmlFile in xmlFiles )
            {
                var cardSource = _xmlParser.Parse(xmlFile);
                if ( cardSource == null )
                    continue;

                foreach ( var csvFile in csvFiles )
                {
                    var userSource = _csvParser.Parse(csvFile);
                    if ( userSource == null )
                        continue;
                    var mergedData = DataMerger.MergeData(userSource, cardSource);
                    if ( mergedData == null )
                        continue;
                    _reportQueue.Enqueue(mergedData);
                    File.Delete(csvFile);
                    File.Delete(xmlFile);
                }
            }
            if ( _reportQueue.Count() > 0 )
                _messageTextBox.Text = $"Можно сгенерировать отчёт. Будет создано: {_reportQueue.Peek().Count()} строк";
        }

        private void _outDirectorySelectionButton_Click(object sender, EventArgs e)
        {
            if ( _outFolderBrowserDialog.ShowDialog() == DialogResult.OK )
            {
                _outPutDirectory = _outFolderBrowserDialog.SelectedPath;
                _selectedOutDirectoryTextBox.Text = _outPutDirectory;
            }
        }

        private void _selectedOutDirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if ( _reportQueue.Count > 0 )
                _messageTextBox.Text = $"Можно сгенерировать отчёт. Будет создано: {_reportQueue.Peek().Count()} строк";
            else
                _messageTextBox.Text = "Нет отчётов для генерации";
        }
    }
}
