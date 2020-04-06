using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    public class BoxUnbox
    {
        public static void Run()
        {
            object Id = 2; // упаковка в значения int в тип Object // значимый в ссылочный
            int id2 = (int)Id;// Распаковка в тип int // ссылочкный в значимый
        }
    }

    class Account<T>
    {
        public T Id { get; set; }
        public int Sum { get; set; }
    }

    // Иногда возникает необходимость присвоить переменным универсальных параметров некоторое начальное значение, 
    // в том числе и null. 
    // Но напрямую мы его присвоить не можем:
    class Account2<T>
    {
        T id = default(T);
    }

    class Account3<T>
    {
        public static T session;

        public T Id { get; set; }
        public int Sum { get; set; }
    }
}
