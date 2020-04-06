using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class Delegate
    {
        delegate int Operation(int x, int y);
        delegate void Message();
        public  void Run()
        {
            Message mes = Hello;
            mes.Invoke();
            Operation op = Add;
            op.Invoke(3, 4);
            Console.Read();

            // ================            

            Func<int, int, int> sum = (x, y) => { return x + y; };
            Console.WriteLine(sum(4, 9));
            Action<string> testDelC = (x) => { Console.WriteLine(x); };
            testDelC("Hello. My name is M and I write lines.");

        }
        private static void Hello() 
        { 
            Console.WriteLine("Hello");
        }
        private static int Add(int x, int y) 
        {
            return x + y; 
        }
    }
}
