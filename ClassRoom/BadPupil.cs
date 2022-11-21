using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class BadPupil : Pupil
    {
        protected override Skill _study()
        {
            if (TiredLevel > 10)
            {
                return Skill.Bad;
            }

            return Skill.Normal;
        }
        protected override Skill _read()
        {
            var rand = new Random();

            if (rand.Next(0, 10) < 8)
            {
                return Skill.Normal;
            }

            return Skill.Bad;
        }

        protected override Skill _write()
        {
            return Skill.Bad;
        }

        protected override Skill _relax()
        {
            var rand = new Random();

            if (TiredLevel < 15)
            {
                return Skill.Bad;
            }

            return Skill.Normal;
        }
    }
}
