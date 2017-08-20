using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Track_Downloader
{
    class Program
    {
        static void Main()
        {
            var blackList = Console.ReadLine().Split(' ');

            var input = Console.ReadLine();
            var tracks = new List<string>();

            while (input != "end")
            {
                var isInBlacklist = false;

                foreach (var blacklistedWord in blackList)
                {
                    if (input.Contains(blacklistedWord))
                    {
                        isInBlacklist = true;
                        break;
                    }
                }

                if (!isInBlacklist)
                {
                    tracks.Add(input);
                }

                input = Console.ReadLine();
            }

            tracks.Sort();

            foreach (var track in tracks)
            {
                Console.WriteLine(track);
            }
        }
    }
}
