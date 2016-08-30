using System;
using System.Collections.Generic;
using System.IO;
using Solid.LogImporterExample.SRPed;

namespace Solid.LogImporterExample.DIPed.After
{
    class LogEntryReader : IDisposable
    {
        private readonly Stream _stream;
        private readonly LogEntryParser _parser;

        public LogEntryReader(Stream stream, LogEntryParser parser)
        {
            _stream = stream;
            _parser = parser;
        }

        public void Dispose()
        {
            _stream.Close();
        }

        public IEnumerable<LogEntry> Read()
        {
            using (var sr = new StreamReader(_stream))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    LogEntry logEntry;
                    if (_parser.TryParse(line, out logEntry))
                    {
                        yield return logEntry;
                    }
                }
            }
        }

        /// <summary>
        /// Можем пойти еще дальше..
        /// </summary>
        public static LogEntryReader FromFile(string fileName)
        {
            var fs = new FileStream(fileName, FileMode.Open);
            var parser = LogEntryParser.Create(fileName);

            return new LogEntryReader(fs, parser);
        }
    }
}
