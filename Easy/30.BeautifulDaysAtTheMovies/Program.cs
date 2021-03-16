using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _30.BeautifulDaysAtTheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ijk = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int starting = ijk[0];
            int ending = ijk[1];
            int k = ijk[2];

            int daysCount = 0;

            for (int i = starting; i <= ending; i++)
            {
                int dayValue = i;
                int copyDayValue = dayValue;
                
                var reversed = 0;

                ReversingNumber(ref copyDayValue, ref reversed);

                int calculation = dayValue - reversed;

                if (calculation % k == 0)
                {
                    daysCount++;
                }
            }

            Console.WriteLine(daysCount);
        }
        private static void ReversingNumber(ref int dayValue, ref int reversed)
        {
            while (dayValue > 0)
            {
                reversed = reversed * 10 + dayValue % 10;
                dayValue /= 10;
            }
        }


    }
}
