using System.Collections.Generic;
using Solid.LogImporterExample.SRPed;

namespace Solid.LogImporterExample.DIPed.Before
{
    public class LogEntryParser
    {
        private readonly IFileReader _fileReader;

        /// <summary>
        /// fileReader нельзя назвать высокоуровневой зависимостью
        /// </summary>
        /// <param name="fileReader"></param>
        public LogEntryParser(IFileReader fileReader)
        {
            _fileReader = fileReader;
        }

        public IEnumerable<LogEntry> ParseLogEntries()
        {
            // Читает файл с помощью _fileReader и разбирает прочитанные строки
            yield break;
        }
    }

    public interface IFileReader
    {
    }
}
