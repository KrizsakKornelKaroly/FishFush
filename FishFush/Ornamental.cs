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
        public Ornamental(string name, string color, double length, int lifespan, int neededSpace, int price) : base(name, color, length, lifespan)
        {
            NeededSpace = neededSpace;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name};{Color};{Length};{Lifespan};{NeededSpace};{Price}";
        }
    }
}
