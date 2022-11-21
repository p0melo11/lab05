using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введiть ключ доступу:");
            var key = Console.ReadLine();
            var path = @"Q:\хааах\lab05\text.txt";

            var DocumentWorker = new DocumentWorker(path);

            switch (key)
            {
                case "pro":
                    DocumentWorker = new ProDocumentWorker(path);
                    Console.WriteLine("Документ вiдкритий");
                    Console.WriteLine("Документ вiдредаговано");
                    Console.WriteLine("Документ збережено у старому форматi, збереження в iнших форматах доступне у версії Експерт");
                    break;
                case "expert":
                    DocumentWorker = new ExpertDocumentWorker(path);
                    Console.WriteLine("Документ вiдкритий");
                    Console.WriteLine("Документ вiдредаговано");
                    Console.WriteLine("Документ збережений в новому форматi");
                    break;
            }

            DocumentWorker.OpenDocument();
            DocumentWorker.SaveDocument("Our father");
            DocumentWorker.EditDocument((oldText) => oldText + "\n Stepan Bandera");
            DocumentWorker.ChangeExtension("docx");
        }
    }
}