using System;
using System.Linq;

namespace _57.CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();

            int upperCaseCount = word.Where(x => char.IsUpper(x)).Count()+1;

            Console.WriteLine(upperCaseCount);
        }
    }
}
