using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFush
{
    internal class Herbivore : Fish
    {
        public Herbivore(string name, string color, double length, int lifespan, string type) : base(name, color, length, lifespan, type)
        {
        }

        public virtual string herbivoreDesc()
        {
            return "Élő eleséget, például rovarlárvákat igényel, csak hasonló méretű halakkal tartható.";
        }

        public override string ToString()
        {
            return $"{Name};{Color};{Length};{Lifespan};{Type}";
        }
    }
}
