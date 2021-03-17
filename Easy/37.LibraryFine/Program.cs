using System;
using System.Linq;

namespace _37.LibraryFine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] returnDate = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] mustReturnDate = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int fine = 0;

            DateTime rd = DateTime.Parse(string.Join(" ", returnDate));
            DateTime mrd = DateTime.Parse(string.Join(" ", mustReturnDate));


            if (rd.Day > mrd.Day && rd.Month == mrd.Month && rd.Year == mrd.Year)
            {
                fine = 15 * Math.Abs(mrd.Day - rd.Day);
            }
            else if (rd.Day > mrd.Day && rd.Month > mrd.Month && rd.Year == mrd.Year)
            {
                fine = 500 * Math.Abs(mrd.Month - rd.Month);
            }
            else if (rd.Year>mrd.Year)
            {
                fine = 10000;
            }

            Console.WriteLine(fine);
        }
    }
}
