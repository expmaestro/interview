using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class Constructor
    {
        public static void Run()
        {
            var a = new B1();
            // Static Constructor B1 
            // Static Constructor A1
            // Constructor A1 
            // Constructor B1
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
    }
}
