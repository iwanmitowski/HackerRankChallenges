using System;
using System.Linq;

namespace _39.JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] clouds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int oneJump = 0;


            int playerPosition = 0;

            for (int i = 0; i <= clouds.Length - 1; i++)
            {


                if (playerPosition +2 < clouds.Length && clouds[playerPosition + 2] == 1)
                {
                    playerPosition++;
                }
                else
                {
                    playerPosition += 2;
                    i = playerPosition;
                }
                oneJump++;

            }

            Console.WriteLine(oneJump);

        }
    }
}
