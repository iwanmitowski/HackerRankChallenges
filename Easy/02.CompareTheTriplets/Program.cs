using System;
using System.Linq;

namespace _02.CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int alicePoints = 0;
            int bobPoints = 0;

            for (int i = 0; i < 3; i++)
            {
                if (a[i]<b[i])
                {
                    bobPoints++;
                }
                else if (a[i]>b[i])
                {
                    alicePoints++;
                }

            }

            Console.WriteLine($"{alicePoints} {bobPoints}");
        }
    }
}
