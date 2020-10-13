using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    // если в List Добавить 1 элемент, Capacity = 4 затем 8, 16, 32
    class ListTest
    {
        public static void Run()
        {
            List<int> arr = new List<int>();
            for (int i = 0; i < 257; i++)
            {
                arr.Add(i + 1);
            }
            Console.WriteLine("Capacity: " + arr.Capacity);
            Console.WriteLine("Count: " +arr.Count);
            Console.WriteLine(arr[0]);
            arr.RemoveAt(0);
            Console.WriteLine("Count: " + arr.Count);
            Console.WriteLine(arr[0]);

            var array = new int[] { 1, 2, 3, 4, 5 };
           // array.
        }
    }
}
