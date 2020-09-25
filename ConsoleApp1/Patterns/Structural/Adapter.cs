using ConsoleApp1.Patterns.Structural.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns.Structural
{
    // мы купили этот код за деньги и он не наш - его менять мы не можем
    // он стоит много денег
    // с помощью адаптера мы преобразовали методы интерфейса IWildCat к интерфейсу купленного кода IHomeCat
    // адаптер позволяет так же преобразовать несклько интерфейсов к одному
    interface IWildCat
    {
        string Breed { get; }
        void Growl();
        void Scratch();
    }

    interface IHomeCat
    {
        string Name { get; set; }

        void Meow();
        void Scratch();
    }

    class YardCat: IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.WriteLine("Мяу мяу");
        }

        public void Scratch()
        {
            Console.WriteLine("Я царапаюсь, но не сильно");
        }
    }

    class PedigreedCat : IHomeCat
    {
        public string Name { get; set; }

        public void Meow()
        {
            Console.WriteLine("Мауууууу");
        }

        public void Scratch()
        {
            Console.WriteLine("Я не царапаюсь");
        }
    }

    // Дикие коты
    class Tiger : IWildCat
    {
        public string Breed => "Тигр обыкновенный";

        public void Growl()
        {
            Console.WriteLine("Grrrrrr");
        }

        public void Scratch()
        {
            Console.WriteLine("У меня очень острые когти, царапаюсь до смерти");
        }
    }

    // мы купили этот код за деньги и он не наш - его менять мы не можем
    // он стоит много денег
    class CatInfoPrinter
    {
        public static void PrintCatInfo(IHomeCat cat)
        {
            Console.WriteLine("Кошачье досье: ");
            Console.WriteLine($"Имя кота: {cat.Name}");
            Console.Write($"Вид мяуканья: ");
            cat.Meow();
            Console.Write($"Вид царапанья: ");
            cat.Scratch();
            Console.WriteLine();
        }
    }

    class Adapter
    {
        public static void Run()
        {
            IHomeCat vaska = new YardCat();
            vaska.Name = "Васька";
            CatInfoPrinter.PrintCatInfo(vaska);

            IHomeCat wagner = new PedigreedCat();
            wagner.Name = "Вагнер";
            CatInfoPrinter.PrintCatInfo(wagner);

            IWildCat tiger = new Tiger();
            HomeCatAdapter adapter = new HomeCatAdapter(tiger);
            CatInfoPrinter.PrintCatInfo(adapter);
        }
    }
}
