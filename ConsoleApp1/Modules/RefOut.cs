using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    public class RefOut
    {

        public static void Run()
        {
            string name = "Sasha";
            Console.WriteLine($"Before default: {name}");           
            Default(name);  //копия переменной будет, переменная не изменится
            Console.WriteLine($"After default: {name}");
            Console.WriteLine("==========================");

            string refName = "Sasha";
            Console.WriteLine($"Before ref: {refName}");
            Ref(ref refName); // метод с передачей параметра по ссылке
            Console.WriteLine($"After ref: {refName}");
            Console.WriteLine("==========================");

           string outName;
           // C# 7.0 
           // Console.WriteLine($"Before out: {outName}");
            Out(out outName); //результат возвращается не через оператор return, а через выходной параметр
            Out(out string test); //результат возвращается не через оператор return, а через выходной параметр
            Console.WriteLine($"After out: {outName}");
            Console.WriteLine($"After out: {test}");

            ReadOnlnly();
        }

        public static void Default(string firstName)
        {
            firstName = "Alena";
        }

        public static void Ref(ref string firstName)
        {
            firstName = "Alena";
        }

        public static void Out(out string firstName)
        {
            firstName = "Alena";
        }

        public static void ReadOnlnly()
        {
            ReadOnly r = new ReadOnly("Not Alex constructor change");
            Console.WriteLine(r.Name);
        }
    }

    public class ReadOnly
    {
        public readonly string Name = "Alex";
        const string MyName = "Alex";

        public ReadOnly(string name)
        {
            //Name = name;
        }
    }
}
