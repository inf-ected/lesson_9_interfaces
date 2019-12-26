using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class Virtual_Lake:IEnumerable
    {
        Duck[] wild_duck =
        {
            new WildDuck("Дикая",2.5f),
            new WildDuck("Дичайшая",3.5f),
            new WildDuck("WildD",4.5f),
            new WildDuck("WildestD",1.5f),
            new WildDuck("Odetta",5.5f),
            new WildDuck("Чирок",6.5f),
            new WildDuck("Нырок",2.5f),
            new WoodDuck("Лесная",33.4f),
            new RubberDuck("WistleDuck",0.5f)
        };
        public void Sort()
        {
            Array.Sort(wild_duck);
        }
        public IEnumerator GetEnumerator()
        {
            return wild_duck.GetEnumerator();
            //throw new NotImplementedException();
        }
        public void Sort(IComparer comparer)
        {
            Array.Sort(wild_duck, comparer);
        }
    }
}
