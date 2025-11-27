using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FishFush
{
    internal class SeaCarnivore : Carnivore
    {
        private double SalinityLevel;
        public SeaCarnivore(string name, string color, double length, int lifespan, bool iscarnivore, double salinityLevel) : base(name, color, length, lifespan, iscarnivore)
        {
            SalinityLevel = salinityLevel;
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
            return $"{Name};{Color};{Length};{Lifespan};{isCarnivore};{SalinityLevel}";
        }
    }
}
