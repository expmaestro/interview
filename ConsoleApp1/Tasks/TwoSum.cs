using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tasks
{
    class TwoSum
    {

        public static void Run()
        {
            Console.WriteLine("===== Start =====");
            var array = new int[] { 20, 1, 2, 3, 4, 53, 4, 434, };
            var target = 8;

            var result = TwoSumRun(array, target);
            Console.WriteLine(string.Join("-", result));
        }

        private static int[] TwoSumRun(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                var current = nums[i]; // 2
                for (var j = i + 1; j < nums.Length; j++)
                {
                    var next = nums[j];
                    if (current + next == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
