using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class WoodDuck : Duck
    {
        public WoodDuck() : this("woody", 2.5f)
        {
        }
        public WoodDuck(string name, float weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public override void Fly() => Console.Write("I fly. ");
        public override void Quack() => Console.Write("I`m mute. ");
       
    }
}
