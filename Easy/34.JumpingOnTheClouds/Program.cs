using System;
using System.Linq;

namespace _34.JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int jumpDistance = nk[1];

            int[] clouds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int playerPosition = 0;
            int energy = 100;

            while (true)
            {
                if (clouds[playerPosition]==1)
                {
                    energy -= 3;
                }
                else
                {
                    energy--;
                }

                if (playerPosition+jumpDistance>=clouds.Length)
                {
                    playerPosition = playerPosition + jumpDistance - clouds.Length ;
                }
                else
                {
                    playerPosition = playerPosition + jumpDistance;

                }
                if (playerPosition==0)
                {
                    break;
                }
            }
            Console.WriteLine(energy);
        }
    }
}
