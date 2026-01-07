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
        private bool Migrant;
        public FreshwaterHerbivore(string name, string color, double length, int lifespan, string type, int toleranceToSalinity, bool migrant) : base(name, color, length, lifespan, type)
        {
            ToleranceToSalinity = toleranceToSalinity;
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
            return $"\n\tMegnevezés: {Name}\n\tSzín: {Color}\n\tHossz: {Length}\n\tÉlettartam: {Lifespan}\n\tTípus: {Type}\n\tVándorló? {isMigrant(Migrant)}\n\tSótűrő képesség: {ToleranceToSalinity}\n\t-----";
        }
    }
}
