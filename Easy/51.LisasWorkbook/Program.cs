using System;
using System.Collections.Generic;
using System.Linq;

namespace _51.LisasWorkbook
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = nk[0];
            int exPerPage = nk[1];

            int[] chaptersAndExercises = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int pages = 1;
            int special = 0;

            for (int i = 0; i < n; i++)
            {
                int exCount = 0;
                int exCont = 0;

                for (int j = 1; j <= chaptersAndExercises[i]; j++)
                {
                    exCount++;
                    exCont++;
                    if (exCount>exPerPage)
                    {
                        exCount = 1;

                        pages++;
                    }
                    if (exCont == pages)
                    {
                        special++;
                    }

                }
                pages++;
            }
            Console.WriteLine(special);

        }
    }
}
