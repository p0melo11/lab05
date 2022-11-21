using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        private Pupil[] _pupils = { };
        public void GetMetrics()
        {
            foreach (var pupil in _pupils)
            {
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                pupil.Study();

                Console.WriteLine($"Рiвень знань: {pupil.KnowledgeLevel}; Рiвень старань {pupil.TiredLevel}");
            }
        }
        public ClassRoom(Pupil pupil)
        {
            Pupil[] pupils = { pupil };

            _pupils = pupils;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            Pupil[] pupils = { pupil1, pupil2 };

            _pupils = pupils;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            Pupil[] pupils = { pupil1, pupil2, pupil3 };

            _pupils = pupils;
        }
    }
}
