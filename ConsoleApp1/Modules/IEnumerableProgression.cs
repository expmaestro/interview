using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    public class IEnum
    {
        public static void Run()
        {
            Progression pr = new Progression(100);

            foreach(int i in pr)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Progression : IEnumerable<int>
    {
        private readonly int _itemCount;     

        public Progression(int itemCount)
        {
            _itemCount = itemCount;
        }

        public IEnumerator<int> GetEnumerator()
        {
            int current1 = 1;
            for(int i = 0; i< _itemCount - 1; i ++) 
            {
                if (i == 0) yield return 1;
                current1 += 3;
                yield return current1;
            }
           // return new ProgressionIterator(_itemCount); - yield return в ILDASM делает такой же класс
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ProgressionIterator : IEnumerator<int>
    {
        private readonly int _itemCount;
        public int _position;
        private int _current;
        public ProgressionIterator(int itemCount)
        {
            _itemCount = itemCount;
            _current = 1;
            _position = 0;

        }
        //  private int _po
        public int Current => _current;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if(_position > 0)
            {
                _current += 3;
            }
            if(_position < _itemCount)
            {
                _position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _current = 1;
            _position = 0;
            // throw new NotImplementedException();
        }
    }
}
