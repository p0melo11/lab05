using System;
using System.Diagnostics;

namespace Printer
{

    class Program
    {
        static void Main()
        {
            Printer ColorPrinter = new ColorPrinter();
            ColorPrinter.Print("qwerty");
        }
    }
}
