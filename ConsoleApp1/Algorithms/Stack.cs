using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms
{
    class StackAlgorithm
    {

        public static void Run()
        {
            // по индеску нельзя
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            foreach (var item in stack)
            {                
                Console.WriteLine(item); // 300, 200, 100
            }

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
