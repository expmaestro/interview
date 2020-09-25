using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tasks
{
    class LongestPrefix
    {
        public static void Run()
        {
            // найти самый длинный общий префикс из этого массива
            string[] strs = new string[] { "abb", "abc", "abcde", "abf" };
            // var newList = list.OrderBy(x => x.Length);
            // Console.WriteLine(string.Join(" - ", newList));

            var result = strs[0];
            for (var i = 1; i < strs.Length; i++)
            {
                while(strs[i].IndexOf(result) != 0)
                {
                    result = result.Substring(0, result.Length - 1);
                    if(string.IsNullOrEmpty(result))
                    {
                       // return "";
                    }
                }
                //if (i == 0)
                //{
                //    result = list[0];
                //}
                //else if (list.Length > 1)
                //{
                //    var prev = result;
                //    var current = list[i];
                //    var common = "";
                //    for(var index = 0; index < prev.Length; index++)  
                //    {                        
                //        if(current.Length > index && prev[index] == current[index])
                //        {
                //            common += prev[index];
                //        }
                //    }
                //    result = common;
                //}

            }
            Console.WriteLine(result);

        }
    }
}
