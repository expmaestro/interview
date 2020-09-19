using ConsoleApp1.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// события построены на основе делегатов
namespace ConsoleApp1.Modules
{
    //1.
    public delegate void CountDelegate(string param);// зачем нам куча одинаковых делегатов, разработчики создали обобщенные 
    public delegate void TimesDelegate(string param); // делегаты Action<T1, T2, T>, Func<T1, T2, T... out>
    //
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

            Func<int, int, string> sum = (x, y) => { return (x + y).ToString(); };
            Console.WriteLine(sum(4, 9));
            Action<string> action = (x) => { Console.WriteLine(x); };
            action("Hello. My name is M and I write lines.");

        }
        private static void Hello() 
        { 
            Console.WriteLine("Hello");
        }
        private static int Add(int x, int y) 
        {
            return x + y; 
        }

        // ===== 2

        public void FindInCollection()
        {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 55, 554, 334, 45345, 5435, 453 };

            Func<int, bool> predicate = NewMethod; //(x) => NewMethod(x);
            Func<int, bool> predicate2 = (x) => NewMethod(x);
            var result = numbers.Where(x => NewMethod(x)).ToList();
            var result2 = numbers.Where(predicate).ToList();
        }

        private  bool NewMethod(int x)
        {
            return x > 10;
        } 
    }
}
