using System;

namespace _31.ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int shared = 5;
            int likedTimes = 0;
            for (int i = 0; i < n; i++)
            {
                int likes = shared / 2;
                likedTimes += likes;
                shared = likes * 3;
            }

            Console.WriteLine(likedTimes);
        }
    }
}
