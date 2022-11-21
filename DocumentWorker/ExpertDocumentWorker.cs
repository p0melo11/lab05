using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public ExpertDocumentWorker(string path) : base(path) { }

        public override void ChangeExtension(string NewExtension)
        {
            {
                var NewPath = System.IO.Path.ChangeExtension(Path, NewExtension);
                File.Move(Path, NewPath);
                Path = NewPath;
            }
        }
    }
}
