using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class HashSetRun
    {
        // HashSet - это список без повторяющихся членов.
        // Поскольку HashSet ограничен, чтобы содержать только уникальные записи, внутренняя структура оптимизирована для поиска(по сравнению со списком) - это значительно быстрее
        // Добавление в HashSet возвращает логическое значение - false, если добавление не выполняется из-за того, что оно уже существует в Set
        // Может выполнять математические операции над множествами: объединение / пересечение / IsSubsetOf и т.Д.
        // HashSet не реализует IList только ICollection
        // Вы не можете использовать индексы с HashSet, только перечислители.
        public static void Run()
        {
            // добавится 2 всего элемента экзепшина не будет
            var t = new HashSet<string>();
            t.Add("Sasha");
            t.Add("Sasha");
            t.Add("Sasha3");
            

            foreach (var item in t)
            {
                Console.WriteLine(item);
            }

            //Основная причина использования HashSet может быть связана с тем, что вы заинтересованы в выполнении операций Set.

            //returns a list of distinct items in both sets
            //HashSet set3 = set1.Union(set2);
        }
    }
}
