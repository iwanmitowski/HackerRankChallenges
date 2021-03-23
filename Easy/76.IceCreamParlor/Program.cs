using System;
using System.Linq;

namespace _76.IceCreamParlor
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int money = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int[] icecreamFlavours = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int firstIndex = 0;
                int secondIndex = 0;

                for (int j = 0; j < n-1; j++)
                {
                    int flavour1 = icecreamFlavours[j];

                    for (int k = j+1; k < n; k++)
                    {
                        int flavour2 = icecreamFlavours[k];
                        
                            if (flavour1+flavour2==money)
                            {
                                firstIndex = j + 1;
                                secondIndex = k + 1;
                            break;
                            }
                        

                    }
                }
                Console.WriteLine($"{firstIndex} {secondIndex}");
            }


        }
    }
}
