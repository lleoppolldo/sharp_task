using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = {
                new int[] {1, 2, 3},
                new int[] {1, 2, 3},
                new int[] {1, 2, 3}
            };
            List<int> list = new List<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (i == j && matrix[i][j] % 2 == 0)
                    {
                        list.Add(getSum(matrix[i]));
                    }
                }
            }
            int sum = 0;
            foreach (int el in list)
            {
                sum += el;
            }
            Console.WriteLine("Итоговая сумма: " + sum);
        }

        static int getSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

    }
}