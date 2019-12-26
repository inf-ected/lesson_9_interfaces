using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9_interfaces
{
    public class Progression : IEnumerable<int>
    {
        private readonly int _itermCount;

        public Progression(int itermCount)
        {
            _itermCount = itermCount;
        }

        public IEnumerator<int> GetEnumerator()
        {

            return new ProgressionIterator(_itermCount);
            //throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ProgressionIterator : IEnumerator<int>
    {
        private readonly int _itemCount;
        private int _position; //cur index
        private int _current;//cur value

        public ProgressionIterator(int itemCount)
        {
            _itemCount = itemCount;
            _current = 1;
            _position = 0;
        }
        //обобщенная форма <T>
        public int Current { get { return _current; } }
        // не обобщенная форма
        object IEnumerator.Current => Current;

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (_position > 0)
                _current += 3;
            if(_position<_itemCount)
            { _position++; return true; }
            return false;
        }

        public void Reset()
        {
            _position = 0;
            _current = 1;
            //throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Progression progression = new Progression(100);
            foreach(int i in progression)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
