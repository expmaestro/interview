using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class StructDisposeRun
    {
        public static void Run()
        {
            using (new StructDispose())
            {

            }
        }
    }
    class StructDispose : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("need implement dispose");
           // throw new NotImplementedException();
        }
    }
}
