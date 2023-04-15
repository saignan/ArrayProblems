using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class Program3
    {
        public static void DescOrder()
        {
            int[] num = { 1,20,32,12,23 };
            Array.Sort(num);
            Array.Reverse(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
        }
    }
}
