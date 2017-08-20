using System;
using System.Collections.Generic;
using System.Linq;

namespace noteStatistics
{
    class noteStatistics
    {
        public static void Main()
        {
            List<double> frequences = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            List<string> notes = new List<string>
            { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

            List<double> freq = new List<double>
            { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            List<string> resNotes = new List<string>();
            List<string> resNaturals = new List<string>();
            List<string> resSharps = new List<string>();
            double naturalSum = 0;
            double sharplSum = 0;

            for (int i = 0; i < frequences.Count; i++)
            {
                var indexNote = freq.IndexOf(frequences[i]);
                resNotes.Add(notes[indexNote]);

                if (notes[indexNote].Length == 1)
                {
                    resNaturals.Add(notes[indexNote]);
                    naturalSum += frequences[i];
                }
                else
                {
                    resSharps.Add(notes[indexNote]);
                    sharplSum += frequences[i];
                }
            }


            Console.WriteLine("Notes: {0}", string.Join(" ", resNotes));
            Console.WriteLine("Naturals: {0}", string.Join(", ", resNaturals));
            Console.WriteLine("Sharps: {0}", string.Join(", ", resSharps));
            Console.WriteLine("Naturals sum: {0}", Math.Round(naturalSum, 2));
            Console.WriteLine("Sharps sum: {0}", Math.Round(sharplSum, 2));
        }
    }
}
