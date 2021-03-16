using System;
using System.Linq;

namespace _23.AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houseRange = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] positionsOfAppleAndOrrangeTree = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int apple = positionsOfAppleAndOrrangeTree[0];
            int orange = positionsOfAppleAndOrrangeTree[1];

            int[] droppedFruits = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int droppedApples = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Select(x => x + apple)
                .Where(x => x >= houseRange[0] && x <= houseRange[1])
                .Count();
                
            int droppedOranges = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Select(x => x + orange)
                .Where(x => x >= houseRange[0] && x <= houseRange[1])
                .Count();

            Console.WriteLine(droppedApples);
            Console.WriteLine(droppedOranges);

        }
    }
}
