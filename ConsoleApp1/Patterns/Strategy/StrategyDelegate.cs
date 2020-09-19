using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns.Strategy
{

    class CalculateWinnersStrategy2
    {
        public string Calculate(Func<string, string> func, string text)
        {
            return func.Invoke(text);
        }
    }

    class ProamRaiting2 
    {
        public string Calculate(string text)
        {
            return "Проам рейтинг победители" + string.Join("-", text.Where(x => char.IsDigit(x)));
        }
    }

    class TancmirRaiting2
    {
        public static string Calculate(string text)
        {
            return "Танцмир рейтинг победители" + string.Join("-", text.Where(x => char.IsDigit(x)));
        }
    }
  
    class StrategyDelegate
    {
        public static void Run()
        {
            Console.WriteLine("-----");
            CalculateWinnersStrategy2 calculateStrategy = new CalculateWinnersStrategy2();
            Console.WriteLine(calculateStrategy.Calculate(new ProamRaiting2().Calculate, "1 2 3 4 5 6"));
            Console.WriteLine(calculateStrategy.Calculate(TancmirRaiting2.Calculate, "6 5 4 3 2 1"));
        }
    }
}
