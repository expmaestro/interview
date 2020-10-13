using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    //Для блокировки с ключевым словом lock используется объект-заглушка, 
    //в данном случае это переменная locker.Когда выполнение доходит до оператора lock, 2
    //объект locker блокируется, и на время его блокировки монопольный доступ к блоку кода имеет только один поток. 
    //После окончания работы блока кода, объект locker освобождается и становится доступным для других потоков.
    class Lock
    {
        private static int x = 0;
        private static object lockObj = new object();
        public static void Run()
        {
            for(int i =0; i < 5; i ++)
            {
                Thread th = new Thread(CountMethod);
                th.Name = $"Поток №{i}";
                th.Start();
            }
        }

        public static void CountMethod()
        {
            lock (lockObj)
            {
                for (x = 1; x < 9; x++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                    Thread.Sleep(100);
                }
            }
           
        }
    }
}
