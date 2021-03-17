using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _41.ACMICPCTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int players = nm[0];
            int maxTopics = nm[1];
            
            Dictionary<int, List<int>> playersAndTopics = new Dictionary<int, List<int>>();

            for (int i = 0; i < players; i++)
            {
                char[] playerTopics = Console.ReadLine().ToCharArray();
                List<int> topicPositions = new List<int>();

                for (int j = 0; j < playerTopics.Length; j++)
                {
                    if (playerTopics[j] == '1')
                    {
                        topicPositions.Add(j);
                    }
                }

                playersAndTopics.Add(i, topicPositions);
            }

            List<int> teamCombinedTopics = new List<int>();
            int maximumTopics = 0;

            for (int i = 0; i < players; i++)
            {
                for (int j = i + 1; j < players; j++)
                {
                    List<int> teamTopics = new List<int>();
                    teamTopics.AddRange(playersAndTopics[i]);
                    teamTopics.AddRange(playersAndTopics[j]);
                    teamTopics = teamTopics.Distinct().ToList();

                    if (teamTopics.Count() > maximumTopics)
                    {
                        maximumTopics = teamTopics.Count();
                    }

                    teamCombinedTopics.Add(teamTopics.Count());
                }
            }

            Console.WriteLine(maximumTopics);
            Console.WriteLine(teamCombinedTopics.Where(x=>x==maximumTopics).Count());
        }
    }
}
