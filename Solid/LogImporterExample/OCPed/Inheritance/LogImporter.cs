namespace Solid.LogImporterExample.OCPed.Inheritance
{
    public class LogImporter
    {
        // Старая версия
        //private readonly LogEntryParser _parser = new LogEntryParser();
        private readonly LogEntryParser _parser;

        public LogImporter(string logFile)
        {
            // Создаем нужный парсер в зависимости от имени файла
            _parser = LogEntryParser.Create(logFile);
        }
    }
}