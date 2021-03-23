using System;
using System.Linq;

namespace _70.CorectnessInvariant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var j = 0;

            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];

                j = i - 1;

                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", A));
        }
    }
}
