using System;
using System.Linq;

namespace _43.BeautifulTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nd = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = nd[0];
            int d = nd[1];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int triplets = 0;
            for (int i = 0; i < n ; i++)
            {
                int firstNum = numbers[i];
                for (int j = i+1; j < n; j++)
                {
                    int secondNum = numbers[j];

                    for (int k = j+1; k < n; k++)
                    {
                        int thirdNum = numbers[k];
                       
                        if (Math.Abs(secondNum-firstNum)==d && Math.Abs(secondNum-thirdNum)==d)
                        {
                            triplets++;
                        }
                    }
                }

            }
            Console.WriteLine(triplets);


        }
    }
}
