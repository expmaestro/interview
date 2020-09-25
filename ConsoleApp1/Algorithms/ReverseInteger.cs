using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Algorithms
{
    class ReverseInteger
    {
        public static int Reverse(int x)
        {
            if (x == 0) return 0;
            string val = x.ToString();
            string newStr = "";
            for (int i = val.Length - 1; i >= 0; i--)
            {
                if (val[i] == '-') continue;
                if (i == val.Length - 1 && val[i] == '0') continue;
                newStr += val[i];
            }
            if (int.TryParse(newStr, out int number))
            {
                if (x < 0)
                    number *= -1;
                return number;
            }
            return 0;

        }
    }
}
