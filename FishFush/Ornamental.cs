using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FishFush
{
    internal class Ornamental : Fish
    {
        private int NeededSpace;
        private int Price;
        public Ornamental(string name, string color, double length, int lifespan, string type, int neededSpace, int price) : base(name, color, length, lifespan, type)
        {
            NeededSpace = neededSpace;
            Price = price;
        }

        public override string ToString()
        {
            return $"\n\tMegnevezés: {Name}\n\tSzín: {Color}\n\tHossz: {Length}\n\tÉlettartam: {Lifespan}\n\tTípus: {Type}\n\tSzükséges hely: {NeededSpace} literes akvárium;\n\tÁr: {Price} Ft\n\t-----";
        }
    }
}
