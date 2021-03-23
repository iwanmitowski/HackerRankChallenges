using System;
using System.Linq;

namespace _72.FindTheMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();

            if (numbers.Length % 2 == 0)
            {
                Console.WriteLine(numbers[numbers.Length / 2] + numbers[numbers.Length / 2 + 1]);
            }
            else
            {
                Console.WriteLine(numbers[numbers.Length / 2]);
            }
        }
    }
}
