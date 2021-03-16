using System;
using System.Linq;

namespace _32.SaveThePrisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();

                long prisoners = input[0];
                long sweets = input[1];
                long chair = input[2];


                long[] positions = new long[prisoners];

                long remainingPrisoner = prisoners - chair + 1;

                if (sweets>remainingPrisoner)
                {
                    chair = 1;
                    sweets -= remainingPrisoner;
                    sweets %= prisoners;

                   

                }
                if (sweets == 0)
                {
                    chair = prisoners;
                }
                else
                {
                    chair += sweets - 1;
                }

                Console.WriteLine(chair);

            }
        }
    }
}
