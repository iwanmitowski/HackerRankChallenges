using System;
using System.Linq;

namespace _14.MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] birds = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int type = birds
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .ThenBy(x=>x.Key)
                .First()
                .Key;
                

            Console.WriteLine(type);
        }
    }
}
