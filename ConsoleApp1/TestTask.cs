using ConsoleApp1.Patterns.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
//    Задан набор точек на плоскости.Требуется определить минимальное число лучей, которые зачеркнут все точки.Лучи выходят из начала координат в направлении заданных точек. Координаты точек целые числа (long).


//Требуется написать функцию в точности соблюдая сигнатуру

//class Solution
//    {
//        public int solution(Point2D[] A);
//    }

//    public class Point2D
//    {
//        public long x;
//        public long y;
//    }

//    Предоставьте решение в виде ссылки на dotnet fiddle как показано ниже
//    https://dotnetfiddle.net/nPIyS6

//Программа должна компилироваться и работать без ошибок
//Напишите оптимальное с точки зрения производительности решение
//Программа будет проверятся при помощи автоматических тестов с различными наборами входных данных

    class Solution
    {
        
        public int solution(Point2D[] A)
        {
            var result = 0;
            if (A == null || A.Length == 0) return result;
            result += Calculate(A, val => val.x >= 0 && val.y > 0);
            result += Calculate(A, val => val.x > 0 && val.y <= 0);
            result += Calculate(A, val => val.x <= 0 && val.y < 0);
            result += Calculate(A, val => val.x < 0 && val.y >= 0);
            return result;
        }

        private static int Calculate(Point2D[] A, Func<Point2D, bool> func)
        {
            int result;
            result = A.Where(func)
                .Select(x => (double)x.x / (double)x.y) // exclude divizion by zero
                .Distinct()
                .Count();
            return result;
        }

        public  void Run()
        {
            var points = new Point2D[] {
               // new Point2D {x = 9223372036854775807, y = 9223372036854775807},
                new Point2D { x = 0, y = 0 },  new Point2D { x = 0, y = 0 },
                 new Point2D { x = 3, y = 0 },  new Point2D { x = 4, y = 0 },
                  new Point2D { x = 0, y = 4 }, new Point2D { x = 0, y = 5 },
                   new Point2D { x = 0, y = -4 }, new Point2D { x = 0, y = -5 },
                   new Point2D { x = -3, y = 0 },  new Point2D { x =- 4, y = 0 },

                //new Point2D { x = 3, y = 1 }, 
                //new Point2D { x = 6, y = 2 },
                //new Point2D { x = 9, y = 3 },

                //new Point2D { x =-3, y = -1 },
                //new Point2D { x = -6, y = -2 },
                //new Point2D { x = -9, y = -3 },
                //new Point2D {x = 1, y =4},
                //new Point2D {x = 2, y = 8}
            };

            Console.WriteLine($"Count of: {solution(points)}");
        }
        
    }
    public class Point2D
    {
        public long x;
        public long y;
    }

    class TestTask
    {
    }
}
