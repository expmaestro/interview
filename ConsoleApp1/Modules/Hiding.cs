using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class Hiding
    {
        public static void Run()
        {
            HiddingB a1 = new HiddingB();
            HiddingA a2 = new HiddingB();
            HiddingA a3 = a1;
            HiddingC a4 = new HiddingC();
            HiddingA a5 = a4;

            a1.Method();
            a2.Method();
            a3.Method();
            a4.Method();
            a5.Method();
        }
    }

    // ======================1===============================
    class HiddingA
    {
        public void Method()
        {
            Console.WriteLine("Method A");
        }
    }

    class HiddingB : HiddingA
    {
        new public void Method()
        {
            Console.WriteLine("Method B");
        }
    }

    class HiddingC : HiddingB
    {
        new public void Method()
        {
            Console.WriteLine("Method C");
        }
    }

    // ====================== 2 ===============================
    class Person1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person1(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    class Employee : Person1
    {
        public string Company { get; set; }
        public Employee(string firstName, string lastName, string company)
                : base(firstName, lastName)
        {
            Company = company;
        }
        public new void Display()
        {
            Console.WriteLine($"{FirstName} {LastName} работает в {Company}");
        }

        
    }

    partial class T1 { partial void Test(); }
    partial class T1 { }
}
