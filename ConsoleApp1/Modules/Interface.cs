using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{

    interface IMovable
    {
        // C# 8.0
        // константа
       // const int minSpeed = 0;     // минимальная скорость
                                    // статическая переменная
       // static int maxSpeed = 60;   // максимальная скорость
                                    // метод
        void Move();                // движение
                                    // свойство
        string Name { get; set; }   // название

       // delegate void MoveHandler(string message);  // определение делегата для события
                                                    // событие
       // event MoveHandler MoveEvent;    // событие движения
    }

    class RunAction : IRunAction
    {
        public void Move()
        {
            Console.WriteLine("I am running");
        }
    }

    interface IAction
    {
        void Move();
    }
    interface IRunAction : IAction
    {
        new void Move();
    }
    class Interface
    {
    }
}
