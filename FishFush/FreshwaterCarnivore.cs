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
        private bool Migrant;
        public FreshwaterCarnivore(string name, string color, double length, int lifespan, string type, int toleranceToSalinity, bool migrant) : base(name, color, length, lifespan, type)
        {
            Migrant = migrant;
            ToleranceToSalinity = toleranceToSalinity;
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
            return $"\n\tMegnevezés:{Name}\n\tSzín: {Color}\n\tHossz: {Length}\n\tÉlettartam: {Lifespan}\n\tTípus: {Type}\n\tVándorló? {isMigrant(Migrant)}\n\tSótűrő képesség: {ToleranceToSalinity}\n\t-----";
        }
    }
}
