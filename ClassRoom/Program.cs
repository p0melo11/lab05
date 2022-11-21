using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main()
        {
            var classRoom = new ClassRoom(new BadPupil(), new ExcelentPupil());

            classRoom.GetMetrics();
        }
    }
}