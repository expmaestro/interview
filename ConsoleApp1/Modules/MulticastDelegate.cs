using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    public class MulticastDelegateClass
    {
        public delegate int CalculateMyNumbers(int x, int y);
        public static void Run()
        {
            int x = 6;
            int y = 7;

            var addMyNumbrers1 = new CalculateMyNumbers(FuncForAddingNumber);
            var addMyNymbers2 = new CalculateMyNumbers(FuncForAddingNumber);
            CalculateMyNumbers multiCast = null;
            multiCast += addMyNumbrers1;
            multiCast += addMyNymbers2;
            var r = multiCast.Invoke(x, y);
            Console.WriteLine(r);

        }

        public static int FuncForAddingNumber(int x, int y)
        {
            return x + y;
        }

    }
}
