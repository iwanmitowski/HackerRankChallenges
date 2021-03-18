using System;
using System.Linq;

namespace _50.ServiceLane
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nt = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int t = nt[1];

            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < t; i++)
            {
                int[] pair = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int start = pair[0];
                int end = pair[1];

                int[] subSizes = new int[end - start+1];
                Array.ConstrainedCopy(sizes,start,subSizes,0,end+1-start);

                int minSize = subSizes.Min();

                Console.WriteLine(minSize);
            }
        }
    }
}
