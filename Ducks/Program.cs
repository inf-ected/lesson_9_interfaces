using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            WildDuck w_duck = new WildDuck("Criacva", 2.5f);
            Console.WriteLine(w_duck);
            w_duck.Swim(); w_duck.Fly(); w_duck.Quack();
            RubberDuck r_duck = new RubberDuck("Scroooooge", 0.5f);
            Console.WriteLine(r_duck);
            r_duck.Swim(); r_duck.Fly(); r_duck.Quack();
            RubberDuck r_duck2 = new RubberDuck("Roger", 0.3f);
            Console.WriteLine(r_duck2);
            r_duck2.Swim(); r_duck2.Fly(); r_duck2.Quack();
            WoodDuck wo_duck1 = new WoodDuck("Flora", 1.5f);
            Console.WriteLine(wo_duck1);
            wo_duck1.Swim(); wo_duck1.Fly(); wo_duck1.Quack();
            WoodDuck wo_duck2 = new WoodDuck("Emma", 1.3f);
            Console.WriteLine(wo_duck2);
            wo_duck2.Swim(); wo_duck2.Fly(); wo_duck2.Quack();

            Virtual_Lake lake = new Virtual_Lake();
            Console.WriteLine("\nList of Ducks from virtual Lake");
            foreach (Duck w in lake)
                Console.WriteLine(w);

            lake.Sort(); // потомучто Icomparable и метод CompareTo
            Console.WriteLine("\nList of Ducks from virtual Lake");
            foreach (Duck w in lake)
                Console.WriteLine(w);

            lake.Sort(new WildDuck());
            Console.WriteLine("\nList of Ducks from virtual Lake");
            foreach (Duck w in lake)
                Console.WriteLine(w);



            Console.ReadKey();
        }
    }
}
