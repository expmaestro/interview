using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    class InheritanceA
    {
       

        public void RunA()
        {
            Console.WriteLine("A Run");
        }
        public virtual void Foo()
        {
            Console.WriteLine("A");
        }
    }

    class InheritanceB : InheritanceA
    {
       
        public void RunB()
        {
            Console.WriteLine("B Run");
        }
        public override void Foo()
        {
            Console.WriteLine("B");
        }
    }

    class Inheritance
    {
        public static void Run()
        {
            InheritanceA a = new InheritanceB();
            a.Foo();
            a.RunA();
        }
    }
}
