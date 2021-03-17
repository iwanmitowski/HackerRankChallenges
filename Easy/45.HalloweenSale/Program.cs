using System;
using System.Linq;

namespace _45.HalloweenSale
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int startingPrice = input[0];
            int discount = input[1];
            int month = input[2];
            int budget = input[3];
                        
            int copyCount = 0;

            while (true)
            {
                
                if (budget - startingPrice >=0)
                {
                    budget -= startingPrice;
                    copyCount++;
                }
                else
                {
                    break;
                }
                
                if (startingPrice-discount <= month)
                {
                    startingPrice = month;

                }
                else
                {
                    startingPrice -= discount;
                }
                
            }
                       
            Console.WriteLine(copyCount);



        }
    }
}
