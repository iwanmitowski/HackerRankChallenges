using System;

namespace _19.Countingvalleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());

            char[] path = Console.ReadLine().ToCharArray();

            int valleys = 0;
            int seaLevel = 0;
            //mountain start sealevel +1 end -1;
            //valley start -1 end +1;
            bool valleyStart = false;


            for (int i = 1; i <= steps ; i++)
            {
                if (path[i - 1] == 'D')
                {
                    seaLevel--;

                    if (seaLevel < 0)
                    {
                        valleyStart = true;
                    }
                }
                else if (path[i - 1] == 'U')
                {
                    seaLevel++;
                    if (seaLevel >= 0)
                    {
                        if (valleyStart == true)
                        {
                            valleys++;
                            valleyStart = false;


                        }
                    }
                }



            }
            Console.WriteLine(valleys);
        }

    }
}
