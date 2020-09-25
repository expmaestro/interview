using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    // 1. запрещаем наследовать Sealed. Мы не можем унаследовать наш класс от Sealed (на нем прервется цепочка наследования )
    // 2. Также можно запретить переопределение методов и свойств. В этом случае их надо объявлять с модификатором sealed:
    class Base
    {

        public static void Run()
        {
            C a = new C();
            a.Print();
            var s = new Sealed();
            int k = 1;
            for (; ; )
            {

            }
        }
    }
    sealed class Sealed : Base // запрещаем наследовать Sealed
    {
    }
    //sealed class Sel : Sealed { } - Error
    class A
    {
        public virtual string Name { get; set; }
        public virtual void First() { Console.Write("First"); }
        public virtual void Print() { Console.WriteLine("Second A"); }
    }
    class B : A
    {
        public sealed override string Name { get; set; }
        //наследники класса не смогут переопределить этот метод так как он sealed
        public sealed override void First()
        {
            base.First();
        }

        public override void Print()
        {
            Console.WriteLine("Second B");
        }

    }
    class C : B
    {
        // public sealed override string Name { get => base.Name; set => base.Name = value; }
        // can not override B.First() because it is sealed
        //public override void First()
        //{
        //    base.First();
        //}
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Second C");
        }
    }
}
