using System;

namespace _09.TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenTime = Console.ReadLine();

            DateTime dt = DateTime.Parse(givenTime);

            Console.WriteLine(dt.ToString("HH:mm:ss"));
        }
    }
}
