using System;
using System.Collections.Generic;

namespace _42.ModifiedKaprekarNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());

            for (int i = p; i < q; i++)
            {
                string currentNumberPow = (i * i).ToString();

                int numberLength = currentNumberPow.Length;
                if (i > 0 && i < 9)
                {
                    if (i == 1)
                        Console.Write($"{i} ");

                    continue;
                }
               
                if (numberLength % 2 == 0)
                {
                    int firstPart = int.Parse(currentNumberPow.Substring(0, numberLength / 2));
                    int secondPart = int.Parse(currentNumberPow.Substring(numberLength / 2));
                    IsKaprekarNum(firstPart, secondPart, i);
                }
                else
                {

                    int firstPart = int.Parse(currentNumberPow.Substring(0, numberLength - (i.ToString().Length)));
                    int secondPart = int.Parse(currentNumberPow.Substring(numberLength - i.ToString().Length));
                    IsKaprekarNum(firstPart, secondPart, i);


                }
            }
        }

        static void IsKaprekarNum(int firstPart, int secondPart, int i)
        {
            if (firstPart + secondPart == i)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
