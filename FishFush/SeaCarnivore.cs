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
        private bool Migrant;
        public SeaCarnivore(string name, string color, double length, int lifespan, string type, double salinityLevel, bool migrant) : base(name, color, length, lifespan, type)
        {
            SalinityLevel = salinityLevel;
            Migrant = migrant;
        }

        public string isMigrant(bool vandorlo)
        {
            if (vandorlo)
            {
                return "Vándorló";
            }
            else
            {
                return "Nem vándorló";
            }
        }

        public override string ToString()
        {
            return $"\n\tMegnevezés: {Name}\n\tSzín: {Color}\n\tHossz: {Length}\n\tÉlettartam: {Lifespan}\n\tTípus: {Type}\n\tVándorló? {isMigrant(Migrant)}\n\tOptimális környezeti sótartalom: {SalinityLevel}%\n\t-----";
        }
    }
}
