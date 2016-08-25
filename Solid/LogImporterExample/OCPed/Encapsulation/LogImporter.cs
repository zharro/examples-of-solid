using System;
using Solid.LogImporterExample.SRPed;

namespace Solid.LogImporterExample.OCPed.Encapsulation
{
    public class LogImporter
    {
        private readonly IObservable<string> _logFileReader; 
        private readonly LogEntryParser _parser = new LogEntryParser();

        public LogImporter(string logFile)
        {
            _logFileReader = new LogFileReader(logFile);
        }

        public void ImportLogs()
        {
            _logFileReader.Subscribe(ProcessString);
        }

        private void ProcessString(string line)
        {
            LogEntry logEntry;
            if (_parser.TryParse(line, out logEntry))
            {
                LogSaver.SaveEntry(logEntry);
            }
        }
    }
}