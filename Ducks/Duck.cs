using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    abstract class Duck:IFlyabe, IQuackable, IComparable, IComparer
    {
       protected string Name;
       protected double Weight;

       

        public abstract void Fly();
        public abstract void Quack();

        public int CompareTo(object obj)
        {
            if (obj is Duck)
                return Weight.CompareTo((obj as Duck).Weight);
            throw new NotImplementedException();
        }
        public int Compare(object x, object y)
        {
            if(x is Duck && y is Duck)
            {
                return string.Compare((x as Duck).Name, (y as Duck).Name);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Name {Name} Weight {Weight}"+ " I am "+ GetType().Name;
        }
        public void Swim()
        {
            Console.Write("I swim. ");
        }
    }
}
