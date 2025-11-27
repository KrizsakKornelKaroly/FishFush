using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FishFush
{
    internal class Carnivore : Fish
    {
        public bool isCarnivore;

        public Carnivore(string name, string color, double length, int lifespan, bool iscarnivore) : base(name, color, length, lifespan)
        {
            isCarnivore = iscarnivore;
        }

        public virtual string carnivoreDesc()
        {
            return "Húsevő faj, kisebb halakkal szemben agresszív lehet.";
        }

        public override string ToString()
        {
            return $"{Name};{Color};{Length};{Lifespan};{isCarnivore}";
        }
    }
}
