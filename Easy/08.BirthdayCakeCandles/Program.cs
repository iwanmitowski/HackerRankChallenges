using System;
using System.Linq;

namespace _08.BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] candles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int mostCandles = candles
                .GroupBy(x => x)
                .OrderByDescending(x=>x.Count())
                .First()
                .Count();
            Console.WriteLine(mostCandles);
        }
    }
}
