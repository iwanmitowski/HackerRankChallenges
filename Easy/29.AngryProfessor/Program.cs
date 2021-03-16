using System;
using System.Linq;

namespace _29.AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int k = nk[1];

                int[] studentTimes = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int onTime = studentTimes.Where(x => x <= 0).Count();

                if (onTime>=k)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
