using System;
using System.IO;

namespace Solid.LogImporterExample.OCPed.Encapsulation
{
    /// <summary>
    /// Такая реализация примитивна, но ее наличие позволит разработчику класса LogImporter 
    /// сосредоточиться на своей части функциональности
    /// </summary>
    public class LogFileReader : IObservable<string>
    {
        private readonly string _fileName;

        public LogFileReader(string fileName)
        {
            _fileName = fileName;
        }

        public IDisposable Subscribe(IObserver<string> observer)
        {
            using (var file = File.OpenText(_fileName))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    observer.OnNext(line);
                }
            }
            observer.OnCompleted();
            throw new NotImplementedException();
        }
    }
}
