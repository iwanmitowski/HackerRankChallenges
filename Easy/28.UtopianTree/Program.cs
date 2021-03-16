using System;

namespace _28.UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int h = 1;

                for (int j = 0; j <= n; j++)
                {
                    if (j==0)
                    {
                        continue;
                    }
                    else if (j%2==0)
                    {
                        h++;
                    }
                    else
                    {
                        h *= 2;
                    }
                }
                Console.WriteLine(h);
            }
        }
    }
}
