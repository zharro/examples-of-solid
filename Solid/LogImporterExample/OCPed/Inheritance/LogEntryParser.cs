using System;
using Solid.LogImporterExample.SRPed;

namespace Solid.LogImporterExample.OCPed.Inheritance
{
    /// <summary>
    /// Класс для анализа записей в логе
    /// </summary>
    public class LogEntryParser
    {
        public bool TryParse(string line, out LogEntry logEntry)
        {
            // Используем регулярное выражение для анализа содержимого строки
            throw new NotImplementedException();
        }

        /// <summary>
        /// Принцип единственного выбора!
        /// </summary>
        public static LogEntryParser Create(string fileName)
        {
            if (fileName.StartsWith("Server"))
            {
                return new BackendLogEntryParser(fileName);
            }
            if (fileName.StartsWith("Postgre"))
            {
                return new PostgreLogEntryParser(fileName);
            }
            throw new InvalidOperationException("Неизвестный формат лога");
        }
    }

    public class PostgreLogEntryParser : LogEntryParser
    {
        public PostgreLogEntryParser(string fileName)
        {
            throw new NotImplementedException();
        }
    }

    public class BackendLogEntryParser : LogEntryParser
    {
        public BackendLogEntryParser(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
