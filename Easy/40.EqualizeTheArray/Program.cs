using System;
using System.Linq;

namespace _40.EqualizeTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] clouds = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int key = clouds.GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .First()
                .Key;
            clouds = clouds.Where(x => x == key).ToArray();
            Console.WriteLine(n-clouds.Count());
                
        }
    }
}
