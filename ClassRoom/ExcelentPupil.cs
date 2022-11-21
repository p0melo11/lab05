using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ExcelentPupil : Pupil
    {
        protected override Skill _study()
        {
            if (TiredLevel > 25)
            {
                return Skill.Bad;
            }

            return Skill.Normal;
        }
        protected override Skill _read()
        {
            var rand = new Random();

            if (rand.Next(0, 10) > 9)
            {
                return Skill.Bad;
            }

            return Skill.Normal;
        }

        protected override Skill _write()
        {
            if (TiredLevel > 20)
            {
                return Skill.Bad;
            }

            return Skill.Normal;
        }

        protected override Skill _relax()
        {
            var rand = new Random();

            if (TiredLevel < 18)
            {
                return Skill.Bad;
            }

            return Skill.Normal;
        }
    }
}
