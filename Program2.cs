using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class Program2
    {
        public void DescendingOrder(int[] arr)
        {
            int swap = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <=arr[j])
                    {
                        swap = arr[j];
                        arr[j] = arr[i];
                        arr[i] = swap;
                    }
                }
                Console.Write(arr[i] + " ");
            }
        }
    }
}
