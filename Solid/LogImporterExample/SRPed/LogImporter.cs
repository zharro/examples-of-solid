using System;
using System.Collections.Generic;
using System.IO;

namespace Solid.LogImporterExample.SRPed
{
    public class LogImporter
    {
        private readonly LogEntryParser _parser = new LogEntryParser();
        private readonly ICollection<string> _logFileNames;

        public LogImporter(ICollection<string> logFileNames)
        {
            _logFileNames = logFileNames;
        }

        public void ImportLogs()
        {
            foreach (var fileName in _logFileNames)
            {
                var logEntries = ReadLogEntries(fileName);
                SaveLogEntries(logEntries);
            }
        }

        private IEnumerable<LogEntry> ReadLogEntries(string fileName)
        {
            // Читаем файл построчно
            using (var file = File.OpenText(fileName))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    LogEntry logEntry;
                    if (_parser.TryParse(line, out logEntry))
                    {
                        yield return logEntry;
                    }
                }
            }
        }

        private void SaveLogEntries(IEnumerable<LogEntry> entries)
        {
            foreach (var entry in entries)
            {
                DateTime dateTime = ParseEntryTime(entry);
                // Сохраняем для полнотекстового поиска
                LogSaver.SaveEntry(dateTime, entry);
            }
        }

        private DateTime ParseEntryTime(LogEntry entry)
        {
            // Получаем время из лог-файла, зная его формат
            throw new NotImplementedException();
        }
    }
}