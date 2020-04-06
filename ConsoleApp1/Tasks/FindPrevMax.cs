using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tasks
{
    class FindPrevMax
    {
        public static void Run()
        {
            var array = new int[] { 8, 10, 1, 2, 3, 6, 7, 7, 7, 5 };
            var max = 0;
            var prevMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var current = array[i];
                if (current > max)
                {
                    prevMax = max;
                    max = current;
                }
                else if (current > prevMax && current != max)
                {
                    prevMax = current;
                }
            }

            Console.WriteLine(prevMax);
        }
    }
}
