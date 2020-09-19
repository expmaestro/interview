using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns.Strategy
{

    interface  ICalculate
    {
        string Calculate(string text);
    }

    class CalculateWinnersStrategy
    {
        public string Calculate(ICalculate calculate, string text)
        {
            return calculate.Calculate(text);           
        }
    }

    class ProamRaiting : ICalculate
    {
        public string Calculate(string text)
        {
            return "Проам рейтинг победители" + string.Join("-", text.Where(x => char.IsDigit(x)));
        }
    }

    class TancmirRaiting : ICalculate
    {
        public string Calculate(string text)
        {
            return "Танцмир рейтинг победители" + string.Join("-", text.Where(x => char.IsDigit(x)));
        }
    }

    class StrategyCalculateWinners
    {
        public static void Run()
        {
            Console.WriteLine("-----");
            CalculateWinnersStrategy calculateStrategy = new CalculateWinnersStrategy();
            Console.WriteLine(calculateStrategy.Calculate(new ProamRaiting(), "1 2 3 4 5 6"));
            Console.WriteLine(calculateStrategy.Calculate(new TancmirRaiting(), "6 5 4 3 2 1")); 
        }
    }
}
