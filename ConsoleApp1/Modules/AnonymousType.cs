using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    public class AnonymousType
    {
        public static void Run()
        {
            // создали на лету тип данных
            // работает благодаря механизму неявной типизации
            var obj = new { Name = "Children Final", Category = 1, CategoryName = 2 };
            string jsonString = JsonConvert.SerializeObject(obj);
            Console.WriteLine(jsonString);
            Console.Write(obj.Name);           
        }
    }
}
