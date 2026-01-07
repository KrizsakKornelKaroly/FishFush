using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFush
{
    internal class Fish
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Length { get; set; }
        public int Lifespan { get; set; }
        public string Type { get; set; }

        public Fish(string name, string color, double length, int lifespan, string type)
        {
            Name = name;
            Color = color;
            Length = length;
            Lifespan = lifespan;
            Type = type;
        }

        public Fish() { }

        public override string ToString()
        {
            return $"{Name};{Color};{Length};{Lifespan}";
        }
    }
}
