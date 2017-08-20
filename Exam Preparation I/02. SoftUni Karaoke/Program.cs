using System;
using System.Collections.Generic;
using System.Linq;



namespace _02.SoftUni_Karaoke
{
    public class Program
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split(',').Select(a => a.Trim()).ToArray();

            var songs = Console.ReadLine().Split(',').Select(a => a.Trim()).ToArray();

            var partAwards = new Dictionary<string, HashSet<string>>();


            var input = Console.ReadLine();

            while(input != "dawn")
            {

                var tokens = input.Split(',').Select(a => a.Trim()).ToArray();
                var participant = tokens[0];
                var song = tokens[1];
                var award = tokens[2];

                if (songs.Contains(song) && participants.Contains(participant))
                {
                    if (!partAwards.ContainsKey(participant))
                    {
                        partAwards[participant] = new HashSet<string>();
                    }

                    partAwards[participant].Add(award);
                }


                input = Console.ReadLine();

            }

            if (!partAwards.Any())
            {
                Console.WriteLine("No awards");
                return;
            }

            var sortedDictionary = partAwards
                .OrderByDescending(a => a.Value.Count)
                .ThenBy(a => a.Key)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var kvp in sortedDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");

                foreach (var award in kvp.Value.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
