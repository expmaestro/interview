using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms
{
    class LinkedList
    {
        public static void Run()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            var t = linkedList.AddFirst(9);
            var next = t.Next.Value = 9;

        }
    }
}
