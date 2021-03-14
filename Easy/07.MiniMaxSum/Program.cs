using System;
using System.Linq;

namespace _07.MiniMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long skipFirst = arr.OrderBy(x => x).Skip(1).Sum();
            long skipLast = arr.OrderByDescending(x => x).Skip(1).Sum();

            Console.WriteLine($"{skipLast} {skipFirst}");
        }
    }
}
