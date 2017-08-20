using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    public class Score
    {
        public decimal Points { get; set; }
        public decimal Goals { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            var key = Regex.Escape(Console.ReadLine());

            var dictionary = new Dictionary<string, Score>();

            var pattern = $@"^.*(?:{key})(?<team1>[a-zA-Z]*)(?:{key}).* .*(?:{key})(?<team2>[a-zA-Z]*)(?:{key}).* (?<team1Score>\d+):(?<team2Score>\d+).*$";

            var input = Console.ReadLine();

            while (input != "final")
            {
                var match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                    
                }


                var teamOneName = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                var teamTwoName = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                var teamOneScore = int.Parse(match.Groups["team1Score"].Value);
                var teamTwoScore = int.Parse(match.Groups["team2Score"].Value);

                if (!dictionary.ContainsKey(teamOneName))
                {
                    dictionary[teamOneName] = new Score();
                }    
                if (!dictionary.ContainsKey(teamTwoName))
                {
                    dictionary[teamTwoName] = new Score();
                }

                if (teamOneScore > teamTwoScore)
                {
                    dictionary[teamOneName].Points += 3;

                }
                 
                else if (teamOneScore == teamTwoScore)
                {
                    dictionary[teamOneName].Points++;
                    dictionary[teamTwoName].Points++;
                }

                else if (teamOneScore < teamTwoScore)
                {
                    dictionary[teamTwoName].Points += 3;

                }

                dictionary[teamOneName].Goals += teamOneScore;
                dictionary[teamTwoName].Goals += teamTwoScore;

                input = Console.ReadLine();


            }
            

            Console.WriteLine("League standings:");

            var standing = dictionary.OrderByDescending(a => a.Value.Points).ThenBy(a => a.Key);
            var place = 1; 

            foreach (var team in standing)
            {
                var teamName = team.Key;
                var teamPoints = team.Value.Points;

                Console.WriteLine($"{place++}. {teamName} {teamPoints}");

            }

            Console.WriteLine("Top 3 scored goals:");

            var golazcos = dictionary.OrderByDescending(a => a.Value.Goals).ThenBy(a => a.Key).Take(3);

            foreach (var goals in golazcos)
            {
                Console.WriteLine($"- {goals.Key} -> {goals.Value.Goals}");
            }
        }
    }
}
