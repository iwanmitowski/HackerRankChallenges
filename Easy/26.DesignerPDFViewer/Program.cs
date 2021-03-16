using System;
using System.Collections.Generic;
using System.Linq;

namespace _26.DesignerPDFViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] letters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string word = Console.ReadLine();

            int a = 97;
            List<int> currentHeight = new List<int>();

            foreach (var c in word)
            {
                currentHeight.Add(letters[(int)c - a]);
            }

            Console.WriteLine(currentHeight.Max()*word.Length);
        }
    }
}
