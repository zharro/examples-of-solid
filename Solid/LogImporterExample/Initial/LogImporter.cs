using System;
using System.Collections.Generic;

namespace Solid.LogImporterExample.Initial
{
    class LogImporter
    {
        public void ImportLogs()
        {
            foreach (var fileName in GetListOfFilesFromAppConfig())
            {
                var logEntries = ReadLogEntries(fileName);
                SaveLogEntries(logEntries);
            }
        }

        public string[] GetListOfFilesFromAppConfig()
        {
            // Читаем список файлов из конфигурационного файла
            throw new NotImplementedException();
        }

        private IEnumerable<string> ReadLogEntries(string fileName)
        {
            // Читаем файл построчно
            throw new NotImplementedException();
        }

        private void SaveLogEntries(IEnumerable<string> entries)
        {
            foreach (var entry in entries)
            {
                DateTime dateTime = ParseEntryTime(entry);
                // Сохраняем для полнотекстового поиска
                LogSaver.SaveEntry(dateTime, entry);
            }
        }

        private DateTime ParseEntryTime(string entry)
        {
            // Получаем время из лог-файла, зная его формат
            throw new NotImplementedException();
        }
    }
}
