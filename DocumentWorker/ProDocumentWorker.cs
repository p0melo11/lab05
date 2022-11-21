using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    public class ProDocumentWorker : DocumentWorker
    {
        public ProDocumentWorker(string path) : base(path) { }

        public override void EditDocument(Func<string, string> ChangeText)
        {
            var text = OpenDocument();
            var newText = ChangeText(text);
            SaveDocument(newText);
        }

        public override void SaveDocument(string text)
        {
            File.WriteAllText(Path, text);
        }
    }
}
