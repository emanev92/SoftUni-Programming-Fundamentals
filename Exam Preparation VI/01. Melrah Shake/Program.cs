using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Melrah_Shake
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var inputPattern = Console.ReadLine();

            Regex regex = new Regex(Regex.Escape(inputPattern));

            MatchCollection matches = regex.Matches(input);

            while (true)
            {
                if (matches.Count >= 2 && inputPattern.Length > 0)
                {
                    var start = input.IndexOf(inputPattern);
                    var last = input.LastIndexOf(inputPattern);

                    input = input.Remove(last, inputPattern.Length);
                    input = input.Remove(start, inputPattern.Length);
                    
                    
                    inputPattern = inputPattern.Remove(inputPattern.Length / 2, 1);

                    Console.WriteLine("Shaked it.");
                }

                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                regex = new Regex(Regex.Escape(inputPattern));
                matches = regex.Matches(input);
            }

            Console.WriteLine(input );
        }
    }
}
