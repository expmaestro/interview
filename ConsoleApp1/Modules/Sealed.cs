using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    //class
    class Base  { 
    
        public static void Run()
        {
            C a = new C();
            a.Second();
            var s = new Sealed();
            int k = 1;
            for(; ; )
            {

            }
        }
    }
    sealed class Sealed : Base
    {
    }
    //sealed class Sel : Sealed { } - Error
    class A
    {
        public virtual void First() { Console.Write("First"); }
        public virtual void Second() { Console.WriteLine("Second A"); }
    }
    class B: A
    {
        sealed public override void First()
        {
            base.First();
        }

        public override void Second()
        {
            Console.WriteLine("Second B");
        }
    }
    class C: B
    {
        public override void Second()
        {
             base.Second();
            Console.WriteLine("Second C");
        }
    }

}
