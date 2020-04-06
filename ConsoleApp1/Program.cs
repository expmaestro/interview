using ConsoleApp1.Modules;
using ConsoleApp1.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{

    public class Test : IEnumerable<int>
    {
        private int[] array = { 3, 5, 6, 10, 20, -1, 0 };

        public object Current => throw new NotImplementedException();

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            foreach (var a in this.array)
            {
                yield return a;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var a in this.array)
            {
                yield return a;
            }
        }
    }
    

    public class Car
    {
        public static int Count { get; set; }
        public int MaxSpeed { get; set; }
        public string Name { get; set; }

        public int GetCount ()
        {
            return Count;
        }

        public void SetCount(int count)
        {
            Count = count;
        }
    }

    public delegate string Action1(int first, int second);
     class Program
    {
        static void Main(string[] args)
        {
            // Closure.Run();
           // new Closure().Run2();
            // RefOut.Run();
            // Immutable.Run();
            // Polymorphism.Run();
            // FinalizeDispose.Run();
            // Sealed.Run();
            // MulticastDelegateClass.Run();
            // Indexers.Run();
            //StructRun.Run();
            //Timer t = new  Timer()
            //StructDisposeRun.Run();
            

            //Object obj = new Byte[84000];
            //Console.WriteLine(GC.GetGeneration(obj));
            Action<int> testDelC = (x) => { Console.WriteLine(x); };

            Hiding.Run();
            //c.
            
        }
    }   

}