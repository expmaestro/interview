using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms
{
    // Алгоритмы сортировки
    //пузырьком
    // Шейкерная
    //Сортировка Расческой или Combo sorting
    //Сортировка Вставками
    //Сортировка Шелла
    //Быстрая сортировка
    // Сортировка деревом
    static class SortAlgorithms
    {
        public static int[] CreateArray()
        {
            return new int[10] { 100, 1, 4, 121, 100, 4, 400, 45, 56, 6 };
        }

        private static void PrintArray(int[] array)
        {
            foreach(var item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void Run()
        {
            
            var array = CreateArray();
            BubbleSort(array);
            PrintArray(array);

            var array2 = CreateArray();
            SortShake(array2);
            PrintArray(array2);

            //Сортировка Вставками
            var array3 = CreateArray();
            InsertionSort(array3);
            PrintArray(array3);

            //Сортировка быстрый поиск
            var array4 = CreateArray();
            QuickSort(array4);
            PrintArray(array4);
        }

        //быстрая сортировка тоже O(n^2) но на средник показателях лучше
        public static  IEnumerable<T> QuickSort<T>(this IEnumerable<T> list) where T: IComparable<T>
        {
            Console.WriteLine("quick sorting");
            if(!list.Any())
            {
                return Enumerable.Empty<T>();
            }
            var pivot = list.First();
            var smaller = list.Skip(1).Where(item => item.CompareTo(pivot) <= 0).QuickSort();
            var larger = list.Skip(1).Where(item => item.CompareTo(pivot) > 1).QuickSort();

            return smaller.Concat(new[] { pivot }).Concat(larger);
        }
        //Сортировка Вставками O(n^2)
        private static int[] InsertionSort(int[] array)
        {
            Console.WriteLine("Insertion Sorting");
            for(int i = 1; i< array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1]) 
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
            return array;
        }

            //shake (балансируем между левым и правым значением)
            private static int[] SortShake(int[] array)
        {
            Console.WriteLine("Shake Sorting");
            int left = 0;
            int right = array.Length - 1;
            int count = 0;

            while(left < right)
            {
                for(int i = left; i< right; i++)
                {
                    count++;
                    if(array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (array[i - 1] > array[i ])
                    {
                        Swap(array,  i - 1, i);
                    }
                }
            }
            return array;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int glass = array[i];
            array[i] = array[j];
            array[j] = glass;
        }

        //int[] nums2 = new int[4] { 1, 2, 3, 5 };
        //int[] nums3 = new int[] { 1, 2, 3, 5 };
        //int[] nums4 = new[] { 1, 2, 3, 5 };
        //int[] nums5 = { 1, 2, 3, 5 };
        // bubble O(n^2)
        private static int[] BubbleSort(int[] array)
        {
            Console.WriteLine("Bubble sort");
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if(array[j + 1] < array[j])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
