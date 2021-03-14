using System;
using System.Linq;

namespace _03.AVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            Console.WriteLine(arr.Sum());
        }
    }
}
