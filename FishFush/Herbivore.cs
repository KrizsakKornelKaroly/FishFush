using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFush
{
    internal class Herbivore : Fish
    {
        public bool isHerbivore;
        public Herbivore(string name, string color, double length, int lifespan, bool isherbivore) : base(name, color, length, lifespan)
        {
            isHerbivore = isherbivore;
        }

        public virtual string herbivoreDesc()
        {
            return "Élő eleséget, például rovarlárvákat igényel, csak hasonló méretű halakkal tartható.";
        }

        public override string ToString()
        {
            return $"{Name};{Color};{Length};{Lifespan};{isHerbivore}";
        }
    }
}
