using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFush
{
    internal class SeaHerbivore : Herbivore
    {
        private double SalinityLevel;
        public SeaHerbivore(string name, string color, double length, int lifespan, bool isherbivore, double salinityLevel) : base(name, color, length, lifespan, isherbivore)
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
            return $"{Name};{Color};{Length};{Lifespan};{isHerbivore};{SalinityLevel}";
        }
    }
}
