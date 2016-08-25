using System;
using System.IO;

namespace Solid.FileStore
{
    public class FileStore
    {
        public string WorkingDirectory { get; set; }

        public string Save(int id, string message)
        {
            var path = Path.Combine(WorkingDirectory, id + ".txt");
            File.WriteAllText(path, message);
            return path;
        }

        public event EventHandler<MessageEventArgs> MessageRead;

        public void Read(int id)
        {
            var path = Path.Combine(WorkingDirectory, id + ".txt");
            var msg = File.ReadAllText(path);
            MessageRead?.Invoke(this, new MessageEventArgs { Message = msg });
        }
    }

    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
