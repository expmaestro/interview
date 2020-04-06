using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    public class Closure
    {
        public static void Run()
        {
            //var actions = new List<Action>();
            //var array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (var item in array)
            //{
            //    actions.Add(() => Console.WriteLine(item));
            //}
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    actions.Add(() => Console.WriteLine(array[i]));
            //}

            //foreach (var a in actions)
            //{
            //    a();
            //}
            // ============== 1=================


        }
        public void Run2()
        {
            var actions = new List<Action>();
            using (var enumerator = Enumerable.Range(1, 3).GetEnumerator())
            {
                // В C# 3.0 и 4.0 current объявлялась здесь
                //int current;
                while (enumerator.MoveNext())
                {
                    // В C# 5.0 current объявляется заново для каждой итерации
                   // var current = enumerator.Current;
                    actions.Add(() => Console.WriteLine(enumerator.Current));
                }
            }

            foreach (var action in actions)
            {
                action();
            }

        }
    }   
}
