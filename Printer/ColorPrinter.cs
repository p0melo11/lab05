using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class ColorPrinter : Printer
    {
        public override void Print(string value)
        {
            var prevColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(value.GetType());

            Console.ForegroundColor = ConsoleColor.Magenta;

            base.Print(value);

            Console.ForegroundColor = prevColor;
        }
    }
}
