using System;

namespace _22.GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int temp = num;
                if (num >= 38)
                {
                    while (true)
                    {
                        temp++;
                        if (temp % 5 == 0)
                        {
                            break;
                        }
                    }
                }

                if (temp - num < 3)
                {
                    Console.WriteLine(temp);
                }
                else
                {
                    Console.WriteLine(num);
                }


            }
        }
    }
}
