using System;
using System.Linq;

namespace _25.TheHurdleRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = nk[1];

            int[] height = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int max = height.Max();

            int doses = max - k;
            if (doses<0)
            {
                doses = 0;
            }
            Console.WriteLine(doses);
        }
    }
}
