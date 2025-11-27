using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFush
{
    internal class FreshwaterCarnivore : Carnivore
    {
        private int ToleranceToSalinity;
        public FreshwaterCarnivore(string name, string color, double length, int lifespan, bool iscarnivore, int toleranceToSalinity) : base(name, color, length, lifespan, iscarnivore)
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
            return $"{Name};{Color};{Length};{Lifespan};{isCarnivore};{ToleranceToSalinity}";
        }
    }
}
