using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public abstract class Pupil
    {
        public enum Skill
        {
            Bad,
            Normal,
            Excelent,
        }

        protected abstract Skill _read();
        protected abstract Skill _write();
        protected abstract Skill _study();
        protected abstract Skill _relax();

        private int _knowledgeLevel = 0;
        public int KnowledgeLevel
        {
            private set
            {
                if (value < 0)
                {
                    _knowledgeLevel = 0;
                    return;
                }

                _knowledgeLevel = value;
            }
            get { return _knowledgeLevel; }
        }

        private int _tiredLevel = 0;
        public int TiredLevel
        {
            private set
            {
                if (value < 0)
                {
                    _knowledgeLevel = 0;
                    return;
                }

                _knowledgeLevel = value;
            }
            get { return _tiredLevel; }
        }
        public void Read()
        {
            var level = _read();

            switch (level)
            {
                case Skill.Bad:
                    _knowledgeLevel += 1;
                    break;
                case Skill.Normal:
                    _knowledgeLevel += 2;
                    break;
                case Skill.Excelent:
                    _knowledgeLevel += 3;
                    break;
            }


            _tiredLevel += 2;
        }

        public void Write()
        {
            var level = _write();

            _knowledgeLevel += 1;

            if (level != Skill.Excelent)
            {
                _tiredLevel += 3;
            }
        }

        public void Study()
        {
            var level = _study();
            var k = (20 / _tiredLevel);

            switch (level)
            {
                case Skill.Bad:
                    _knowledgeLevel += k;
                    break;
                case Skill.Normal:
                    _knowledgeLevel += 2 * k;
                    break;
                case Skill.Excelent:
                    _knowledgeLevel += 3 * k;
                    break;
            }


            _tiredLevel += 5;
        }

        public void Relax()
        {
            var level = _read();

            switch (level)
            {
                case Skill.Bad:
                    TiredLevel -= 3;
                    break;
                case Skill.Normal:
                    TiredLevel -= 5;
                    break;
                case Skill.Excelent:
                    TiredLevel -= 10;
                    break;
            }

            KnowledgeLevel -= 1;
        }
    }
}
