using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class Indexers
    {
        public static void Run()
        {
            MyCollection<int> m = new Modules.MyCollection<int> { };
            m.Add(6);
            Console.WriteLine(m[0]);
        }
    }

    public class MyCollection<T>
    {
        public void Add(T item)
        {
            array.Add(item);
        }
        private List<T> array = new List<T>();

        public T this[int t] { get { return array[t]; } set { array[t] = value; } }
    }
}
