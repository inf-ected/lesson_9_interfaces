using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class WildDuck:Duck
    {
        public WildDuck(): this("Criacva", 2.5f) { }
        public WildDuck(string name, float weight)// : base(name, weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public override void Fly() => Console.Write("I fly. ");

        public override void Quack() => Console.Write("I Quack. ");

    }
}
