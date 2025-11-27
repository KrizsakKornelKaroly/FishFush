using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFush
{
    internal class FreshwaterHerbivore : Herbivore
    {
        private int ToleranceToSalinity;
        public FreshwaterHerbivore(string name, string color, double length, int lifespan, bool isherbivore, int toleranceToSalinity) : base(name, color, length, lifespan, isherbivore)
        {
            ToleranceToSalinity = toleranceToSalinity;
        }

        public string isMigrant(bool vandorlo)
        {
            if (vandorlo)
            {
                return "Vándorló faj.";
            }
            else
            {
                return "Nem vándorló faj.";
            }
        }

        public override string ToString()
        {
            return $"{Name};{Color};{Length};{Lifespan};{isHerbivore};{ToleranceToSalinity}";
        }
    }
}
