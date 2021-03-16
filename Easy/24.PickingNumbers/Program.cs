using System;
using System.Linq;

namespace _24.PickingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();

            int maxSequence = 0;



            for (int i = 0; i < n; i++)
            {
                int currentSequence = 1;

                for (int j = i + 1; j < n; j++)
                {
                    int firstNum = numbers[i];
                    int secondNum = numbers[j];

                    if (Math.Abs(firstNum - secondNum) <= 1)
                    {
                        currentSequence++;
                    }
                    else
                    {
                        break;
                    }

                }
                if (currentSequence >= maxSequence)
                {
                    maxSequence = currentSequence;
                }

            }

            Console.WriteLine(maxSequence);
        }
    }
}
