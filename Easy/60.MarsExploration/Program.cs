using System;
using System.Linq;

namespace _60.MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            int counter = 0;

            for (int i = 0; i < message.Length; i+=3)
            {
                char firstL = message[i];
                char secondL = message[i+1];
                char thirdL = message[i+2];

                if (message[i]!='S')
                {
                    counter++;
                }
                if (message[i+1]!='O')
                {
                    counter++;
                }
                if (message[i + 2] != 'S')
                {
                    counter++;
                }
                
            }

            Console.WriteLine(counter);
        }
    }
}
