using System;

namespace _14.DayOfTheProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            bool isLeap = false;

            if (year == 1918)
            {
                Console.WriteLine($"26.09.{year}");
                Environment.Exit(0);
            }
            else if (year <= 1700 || year<1918)
            {
                if (year % 4 == 0)
                {
                    isLeap = true;
                }
            }
             
            else 
            {
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                {
                    isLeap = true;
                }
            }

            if (isLeap)
            {
                Console.WriteLine($"12.09.{year}");

            }
            else
            {
                Console.WriteLine($"13.09.{year}");

            }
        }
    }
}
