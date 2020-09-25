using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class Credit
    {
        public virtual decimal Sum { get; set; }
    }
    class LongCredit: Credit
    {
        private decimal sum;
        public override decimal Sum 
        { 
            get => sum; 
            set
            {
                if(value > 100)
                {
                    sum = value;
                }
            }
        }
    }
    class GetSet
    {
        public static void Run()
        {
            Console.WriteLine($"================== Get Set  ==================");
            var longCredit = new LongCredit();
            longCredit.Sum = 5;
            Console.WriteLine($"Credit: {longCredit.Sum}");
            longCredit.Sum = 200;
            Console.WriteLine($"Credit: {longCredit.Sum}");

            Console.WriteLine($"================== End Get Set  ==================");
        }
    }
}
