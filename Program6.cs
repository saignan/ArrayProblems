using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    internal class Program6
    {
        public static void AddDiagonal()
        {
            int[,] num = {{10,3,2,6,7},{2,4,1,6,8},{8,4,6,2,8},{3,2,6,18,9},{2,1,4,3,8}};

            //Getting Row and Column Length
            int rowlength = num.GetLength(0);
            int columnlength = num.GetLength(1);
            int total = 0;
            Console.Write("Diagonals are : ");
            for (int row = 0; row < rowlength; row++)
            {
                for (int column = 0; column < columnlength; column++)
                {
                    if (row == column)
                    {
                        Console.Write(num[row, column] + " ");
                        total += num[row, column];
                    }
                }
            }
            Console.WriteLine(" Sum : " + total);
        }

    }

}
