using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class Constructor
    {
        public static void Run()
        {
            Console.WriteLine("===========Constructor==========");
            C1 c = new C1();
            Console.WriteLine("====================");
            // Static Constructor C1 
            // Static Constructor B1 
            // Static Constructor A1
            // Constructor A1 
            // Constructor B1
            // Constructor C1
            A1 a1c1 = new C1();
            Console.WriteLine("====================");
            A1 a1 = new B1("test");
            A1 a11 = new C1();
            Console.WriteLine("====================");

            ////2 
            //Bus.Drive();

            ////3.
            //AA ab = new BB("quizful");
            //AA ac = new CC();
        }
    }

    public class A1
    {
        static A1()
        {
            Console.WriteLine("Static Constructor A1");
        }
        public A1()
        {
            Console.WriteLine("Constructor A1");
        }
    }

    public class B1: A1
    {
        static B1()
        {
            Console.WriteLine("Static Constructor B1");
        }
        public B1()
        {
            Console.WriteLine("Constructor B1");
        }

        public B1(string param)
        {
            Console.WriteLine("Constructor B1 with param");
        }
    }

    public class C1: B1
    {
        static C1()
        {
            Console.WriteLine("Static Constructor C1");
        }

        public C1()
        {
            Console.WriteLine("Constructor C1");
        }

        public C1(string text)
        {
            Console.WriteLine("Constructro C1 with param");
        }
    }

    // 2. Test only static   
    public class Car1
    {
        public Car1()
        {
            System.Console.WriteLine("The Car constructor invoked.");
        }
    }
    public class Bus : Car1
    {
        static Bus()
        {
            System.Console.WriteLine("The Bus static constructor invoked.");
        }

        public Bus()
        {
            System.Console.WriteLine("The Bus constructor invoked.");
        }

        public static void Drive()
        {
            System.Console.WriteLine("The Drive method invoked.");
        }
    }

    //3.
    class AA
    {
        public AA() { Console.WriteLine("A created"); }
    }
    class BB : AA
    {
        private BB() { Console.WriteLine("B created"); }

        public BB(string parameter)
        {
            Console.WriteLine("B created with parameter: {0}", parameter);
        }

    }
    class CC : BB
    {
        public CC(): base("C")
        {
            Console.WriteLine("C created");
        }
    }
}
