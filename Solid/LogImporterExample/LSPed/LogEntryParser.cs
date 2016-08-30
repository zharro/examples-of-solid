using System.Diagnostics.Contracts;
using Solid.LogImporterExample.SRPed;

namespace Solid.LogImporterExample.LSPed
{
    [ContractClass(typeof(LogEntryParserContract))]
    public abstract class LogEntryParser
    {
        /// <summary>
        /// Анализирует переданную строку и возвращает результат
        /// через <paramref name="logEntry"/>>
        /// </summary>
        /// <exception cref="LogEntryParserException">
        /// Генерируется, если переданная строка не соответствует
        /// ожидаемому формату
        /// </exception>
        public abstract bool TryParse(string line, out LogEntry logEntry);
    }

    [ContractClassFor(typeof(LogEntryParser))]
    abstract class LogEntryParserContract : LogEntryParser
    {
        public override bool TryParse(string line, out LogEntry logEntry)
        {
            Contract.Requires(line != null);
            Contract.Ensures(!Contract.Result<bool>() || Contract.ValueAtReturn(out logEntry) != null,
                "Если результат True, то logEntry не может быть null");
            throw new System.NotImplementedException();
        }
    }
}
