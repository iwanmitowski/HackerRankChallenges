using System;

namespace _65.FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int t = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < t; i++)
            {
                string number = Console.ReadLine();
                int numberParsed = int.Parse(number);

                int counter = 0;
                
                foreach (var dig in number)
                {
                    int d = int.Parse(dig.ToString());

                    if (d==0)
                    {
                        continue;
                    }
                    int calc = numberParsed % d;
                    if (calc == 0)
                    {
                        counter++;
                    }
                }

                Console.WriteLine(counter);
            }
        }
    }
}
