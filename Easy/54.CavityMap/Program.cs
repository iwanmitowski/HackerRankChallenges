using System;
using System.Linq;

namespace _54.CavityMap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }

            }

            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 1; j < n - 1; j++)
                {
                    //горни и долни
                    int up;
                    int down;
                    int left;
                    int right;

                    if (!int.TryParse(matrix[i - 1, j].ToString(), out up) ||
                        !int.TryParse(matrix[i + 1, j].ToString(), out down) ||
                        !int.TryParse(matrix[i, j - 1].ToString(), out left) ||
                        !int.TryParse(matrix[i, j + 1].ToString(), out left))
                    {
                        continue;
                    }

                    int current = int.Parse(matrix[i, j].ToString());


                    if (current>up&&current>down&&current>left&&current>down)
                    {
                        matrix[i, j] = 'X';
                    }

                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
