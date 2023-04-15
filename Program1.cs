using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a Program to Print One Dimensional Array in Reverse Order

namespace ArrayProblems
{
    internal class Program1
    {
        public static void ReverseOrder()
        {
            int[] num = {1,2,3,4,5};
            Array.Reverse(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
        }
    }
}
