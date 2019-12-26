using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class RubberDuck : Duck
    {
        public RubberDuck():this("Scrooge",0.5f){}
        public RubberDuck(string name, float weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public override void Fly() => Console.Write("I don`t fly. ");
        public override void Quack() => Console.Write("I whistle. ");
    }
}
