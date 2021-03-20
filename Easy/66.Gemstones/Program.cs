using System;
using System.Collections.Generic;
using System.Linq;

namespace _66.Gemstones
{
    class Program
    {
        static void Main(string[] args)
        {
            int rocks = int.Parse(Console.ReadLine());
            List<string> rockList = new List<string>();

            for (int i = 0; i < rocks; i++)
            {
                string input = Console.ReadLine();
                rockList.Add(input);
            }

            char[] highetstMineralRock = string.Join("",rockList).ToCharArray().Distinct().ToArray();

            int gemstones = 0;
            
            foreach (var mineral in highetstMineralRock)
            {
                int counter = 0;
                foreach (var rock in rockList)
                {
                    if (rock.Contains(mineral))
                    {
                        counter++;
                        
                    }
                }
                if (counter==rockList.Count)
                {
                    gemstones++;
                }
            }

            Console.WriteLine(gemstones);
        }
    }
}
