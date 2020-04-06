using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    public class Immutable
    {

        public static void Run()
        {
            // - неизменяемость несет в себе потенциальные проблемы с производительностью необходимость создавать его копию при каждом изменении может стать проблемой
            // + Объекты неизменяемых типов потокобезопасны (многопоточность)
            // «изменение» переменной, используемой в качестве ключа, не влияет на работу хеш-таблицы:
            Car c = new Car("Honda Accord", 240, 700000);
            Console.WriteLine(c.ReduceSpeed().MaxSpeed);

            //«изменение» переменной, используемой в качестве ключа, не влияет на работу хеш-таблицы:
            Dictionary<string, int> dic = new Dictionary<string, int>();
            var key = "first";
            dic.Add(key, 14);
            key = "second";
            var temp = dic["first"];
            Console.WriteLine(temp);

        }

    }

    public class Car
    {
        public Car(string name, int maxSpeed, decimal price)
        {
            Name = name;
            MaxSpeed = maxSpeed;
            Price = price;
        }

        public string Name { get; } // C# 6 remove private set
        public int MaxSpeed { get; private set; }
        public decimal Price { get; private set; }

        public Car ReduceSpeed()
        {
            return new Car(Name, MaxSpeed - 1, Price);
        }
    }
}
