using System;
using System.Linq;

namespace _04.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] colNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = colNums[j];
                }
            }

            int mainDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                mainDiagonal += matrix[i, i];
                secondaryDiagonal += matrix[i, n- 1 - i];
            }

            Console.WriteLine(Math.Abs(mainDiagonal - secondaryDiagonal));
        }
    }
}
