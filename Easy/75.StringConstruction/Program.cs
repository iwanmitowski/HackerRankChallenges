using System;
using System.Linq;

namespace _75.StringConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int cost = Console.ReadLine().ToCharArray().Distinct().Count();

                Console.WriteLine(cost);
            }
        }
    }
}
