using System;
using System.Linq;

namespace _12.SubarrayDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] chocolate = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] dm = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int d = dm[0];
            int m = dm[1];

            int blocks = 0;

            for (int i = 0; i < n; i ++)
            {
                int calculation = 0;
                for (int j = 0; j < m; j++)
                {
                    if (j + i == n)
                    {
                        if (chocolate.Last()+chocolate[i]==d)
                        {
                            blocks++;
                        }
                        break;
                    }
                    calculation += chocolate[i + j];

                }
                if (calculation == d)
                {
                    blocks++;
                }
            }

            Console.WriteLine(blocks);
        }
    }
}
