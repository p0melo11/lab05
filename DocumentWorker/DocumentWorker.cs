using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    public class DocumentWorker
    {
        public string Path;
        private string? _text;

        public DocumentWorker(string path)
        {
            Path = path;
        }

        public string OpenDocument()
        {
            string text = File.ReadAllText(Path);

            _text = text;

            return text;
        }

        public virtual void EditDocument(Func<string, string> ChangeText)
        {
            Console.WriteLine("Правка документа доступна у версiї Про");
        }

        public virtual void SaveDocument(string text)
        {
            Console.WriteLine("Збереження документа доступне у версiї Про");
        }
        public virtual void ChangeExtension(string NewExtension)
        {
            Console.WriteLine("Змiна формату документа достпуна у версiї Експерт");
        }
    }
}
