using System;
using System.Linq;

namespace _21.CatsAndMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                int[] positions = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int catA = positions[0];
                int catB = positions[1];
                int mouseC = positions[2];


                if (Math.Abs(catA-mouseC) == Math.Abs(catB - mouseC))
                {
                    Console.WriteLine("Mouse C");
                }
                else
                {
                    Console.WriteLine(Math.Abs(catA - mouseC) < Math.Abs(catB - mouseC) ? "Cat A" : "Cat B");
                }
            }
        }
    }
}
