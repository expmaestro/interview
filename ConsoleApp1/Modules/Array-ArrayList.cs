using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Array_ArrayList // массивы ссылочные типы
    {
        // массив не ресайзится
        // Массивы идеальны, когда вы знаете, сколько предметов вы собираетесь вставить. O(1)
        // массивы многомерны, но ArrayList всегда одномерен.
        // ArrayLists используют динамически расширяющийся массив
        // List out the differences between Array and ArrayList in C#?
        // Array stores the values or elements of same data type but arraylist stores values of different datatypes.
        // Arrays will use the fixed length but arraylist does not uses fixed length like array.
        public static void Run()
        {
            var array = new int[5];
            array[0] = 7;
            array[2] = 2;
            array[3] = 2;
            array[4] = 2;
            
            ArrayList al = new ArrayList();
            Array myArr = Array.CreateInstance(typeof(string), 5);
            myArr.SetValue("Name", 0);
            myArr.SetValue("Name", 0);
            Array.Sort(array);
            Array.Reverse(array);
            
            foreach (var a in array)
            {
                Console.WriteLine(a); // 0 2 2 2 7 //warning 0 - так как нет первого идекса
            }
            // a.Sort();


            var list = new List<Person>() { };//O(N)(immutable list)

        }
    }
}
