using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Type1
    {
        string Name { get { return "Name"; } }
        //string Test { get; set; }
        static void Run()
        {
            int[][] k1 = new int[2][];
            Func<int> d;

            d = () => 0;
            d += () => 1;
            Type t1 = typeof(System.Int32);
            Type t2 = Type.GetType("System.Int32");
            //  Type t3 = Type.GetType(System.Int32); // error
            // Type t4 = System.Int32.GetType(); // error
            int[] some = new int[4];

            int k = 1;
            switch(k) {
                case 0:
                case 1: Console.WriteLine("1"); break;
                case 2: Console.WriteLine("1"); break;
                case 3:
                default: Console.WriteLine("1"); break;
            }

        }
    }
}
