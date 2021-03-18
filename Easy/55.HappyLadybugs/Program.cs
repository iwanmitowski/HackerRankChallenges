using System;
using System.Linq;

namespace _55.HappyLadybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = int.Parse(Console.ReadLine());

            for (int i = 0; i < g; i++)
            {
                int n = int.Parse(Console.ReadLine());
                bool isHappy = true;

                char[] currentGame = Console.ReadLine().ToCharArray();

                if (currentGame.Length == 1 && currentGame[0] != '_')
                {
                    Console.WriteLine("NO");
                    continue;
                }
                
                if (currentGame
                   .GroupBy(x => x)
                   .Any(x => (x.Count() == 1) && x.Key != '_')
                   || currentGame
                   .GroupBy(x => x)

                   .Where(x => x.Key == '_')
                   .Count() < 1
                   )

                {
                    isHappy = false;
                }
                

                if (currentGame.Distinct().Count() == 1)
                {
                    isHappy = true;
                }

                if (isHappy)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

            }

        }

    }
}

