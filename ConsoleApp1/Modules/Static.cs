using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class Student
    {
        //Статический член типа относится не к экземпляру а ко всему типу в целом
        public static int _staticField;
        public int _instanceField;
        public void SetValue(int value)
        {
            // экземпляры видят статические поля, 
            //так как статик поля общие для всех экземпляров
            _staticField = value;
            this._instanceField = value;
        }

        public static void SetValueStatic(int value)
        {
            _staticField = value;
            //Ошибка не можем получить достук а экземплярным полям типа, 
            //так как статик не привязанны к экземпляру типа
            // _instanceField = value; - так нельзя, можно через 
            Student student = new Student();
            student._instanceField = 100;
        }
    }
    
    class Static
    {
        public static   void Run()
        {
            Student studen1 = new Student();
            Student studen2 = new Student();
            Student studen3 = new Student();

            studen1._instanceField = 1;
            studen2._instanceField = 2;

            Student._staticField = 100; // Обращаемся к статику из типа, а не из экземпляра

            Console.WriteLine($"Первое экземплярное поле {studen1._instanceField}"); // 1
            Console.WriteLine($"Второе экземплярное поле {studen2._instanceField}"); // 2
            Console.WriteLine($"Статическое поле {Student._staticField}"); // 100
        }
    }
}
