using System;
using Solid.LogImporterExample.SRPed;

namespace Solid.LogImporterExample.DIPed.After
{
    public class LogEntryParser
    {
        public bool TryParse(string line, out LogEntry logEntry)
        {
            // Используем регулярное выражение для анализа содержимого строки
            throw new NotImplementedException();
        }

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
        public PostgreLogEntryParser(string fileReader)
        {
            throw new NotImplementedException();
        }
    }

    public class BackendLogEntryParser : LogEntryParser
    {
        public BackendLogEntryParser(string fileReader)
        {
            throw new NotImplementedException();
        }
    }

    public interface IFileReader
    {
    }
}