using System;
using System.Linq;

namespace _52.FlatlandSpaceStations
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int citiesCount = nm[0];
            int stationsCount = nm[1];

            if (citiesCount==stationsCount)
            {
                Console.WriteLine("0");
                Environment.Exit(0);
            }
                        
            int[] spaceStations = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxDistance = 0;

            int[] stationCalculations = new int[stationsCount]; 

            for (int i = 0; i < citiesCount; i++)
            {
                if (spaceStations.Contains(i))
                {
                    continue;
                }

                for (int j = 0; j < stationsCount; j++)
                {
                    int calc = Math.Abs(spaceStations[j] - i);
                    stationCalculations[j] = calc;
                }

                int minDist = stationCalculations.Min();

                if (minDist > maxDistance)
                {
                    maxDistance = minDist;

                }
            }

            Console.WriteLine(maxDistance);
        }
    }
}
