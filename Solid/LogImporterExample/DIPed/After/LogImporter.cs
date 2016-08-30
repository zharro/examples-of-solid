using System;
using Solid.LogImporterExample.OCPed.Encapsulation;

namespace Solid.LogImporterExample.DIPed.After
{
    public class LogImporter : IDisposable
    {
        private readonly LogEntryReader _logEntryReader;

        public LogImporter(string logFile)
        {
            // Создаем нужный парсер в зависимости от имени файла
            _logEntryReader = LogEntryReader.FromFile(logFile);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            _logEntryReader.Dispose();
        }

        public void ImportLogs()
        {
            foreach (var logEntry in _logEntryReader.Read())
            {
                LogSaver.SaveEntry(logEntry);
            }
        }
    }
}