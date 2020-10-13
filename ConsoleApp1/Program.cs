using ConsoleApp1.Algorithms;
using ConsoleApp1.Modules;
using ConsoleApp1.Patterns.Behavioral;
using ConsoleApp1.Patterns.Strategy;
using ConsoleApp1.Patterns.Structural;
using ConsoleApp1.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
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
            SortAlgorithms.Run();
            // SortAlgorithms.Run();
            //StackAlgorithm.Run();
            //  QueueAlgorithm.Run();
            // Closure.Run();
            // new Closure().Run2();
            RefOut.Run();
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
            //Action<int> testDelC = (x) => { Console.WriteLine(x); };

            //Hiding.Run();
            //var p = new Person() { Id = 1, Name = "Bmw" };
            //var p1 = p;
            //p.Name = "Mercedes";
            //p = null;
            //Console.WriteLine(p1.Name);

            Constructor.Run();
            //  StructRun.Run();
            // Inheritance.Run();
            //Strategy.Run();
            //StrategyCalculateWinners.Run();
            // TemplateMethod.Run();
            // Decorator.Run();
            // FacadeRun.Run();
            //Adapter.Run();
            //Events.Run();
            // RefOut.Run();

            ISet<int> set = new HashSet<int> { 1, 2, 3, 4, 5, 1, 2, 3, 88, 5, 543, 534, 5, 43, 1, 1, 1, 1, 1, 1 };
            Console.WriteLine(string.Join("-", set));

            // GetSet.Run();
            // Static.Run();
            // Abstract.Run();
            //Closure.Run3();
            //try
            //{
            //    Exceptions.Run();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}

            // LongestPrefix.Run();
            //Action<int, int> fc = null;
            //fc = (i, max) =>
            //{
            //    Console.WriteLine(i);
            //    if (i < max) fc(++i, max); // рекурсия
            //};
            //fc(0, 10);


            // IEnum.Run();
            //HashSetRun.Run();
            // Lock.Run();
            //var data = new List<Point2D>
            //{ new Point2D { x = 0, y = 0 },
            //     new Point2D { x = 3, y = 1 }};

            //var result = data.Select(s => (double)s.x / (double)s.y).ToList();

            //foreach (var r in result)
            //{
            //    Console.WriteLine(r.GetType()); // double

            //}
            //var c = 1;
            //var cat  = new Cat();

           // ListTest.Run();

        }



       
    }

    
}


