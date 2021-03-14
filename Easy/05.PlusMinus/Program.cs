using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            decimal posCount = arr.Where(x => x > 0).Count();
            decimal negCount = arr.Where(x => x < 0).Count(); 
            decimal zeroCount = arr.Where(x => x == 0).Count();

            Console.WriteLine($"{posCount/n:f6}");
            Console.WriteLine($"{negCount/n:f6}");
            Console.WriteLine($"{zeroCount/n:f6}");

        }
    }
}
