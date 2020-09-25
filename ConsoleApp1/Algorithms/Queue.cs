using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms
{
    class QueueAlgorithm
    {
        public static void Run()
        {
            // по индеску нельзя
            Queue<int> queue = new Queue<int>();
            
            queue.Enqueue(50);
            queue.Enqueue(60);
            queue.Enqueue(70);
            //var t = queue
            foreach (var item in queue)
            {
                Console.WriteLine(item); // 300, 200, 100
            }

            while (queue.Count > 0)
            {
              Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
