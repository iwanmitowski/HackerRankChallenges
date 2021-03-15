using System;

namespace _18.DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int pageToTurn = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Min(pageToTurn/2,bookPages/2-pageToTurn/2));
            
        }
    }
}
