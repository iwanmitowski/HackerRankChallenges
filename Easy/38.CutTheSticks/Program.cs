using System;
using System.Collections.Generic;
using System.Linq;

namespace _38.CutTheSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> sticks = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (sticks.Count != 0)
            {
                Console.WriteLine(sticks.Count);
                sticks = sticks.Select(x => x - sticks.Min()).Where(x => x > 0).ToList();
            }


        }
    }
}
