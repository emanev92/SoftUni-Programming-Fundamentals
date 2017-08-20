using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    public class Program
    {
        public static void Main()
        {
            var pattern = @"^(?<leftPart>\d+)(?<message>[a-zA-Z]+)(?<rightPart>[^a-zA-Z]+)?$";

            var input = Console.ReadLine();

            while (input != "Over!")
            {
                var match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var messageLength = int.Parse(Console.ReadLine());

                var message = match.Groups["message"].Value;

                if (message.Length != messageLength)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var leftPart = match.Groups["leftPart"].Value;
                var rightPart = match.Groups["rightPart"].Value;

                var verificationCode = string.Empty;

                var verification = leftPart + rightPart;

                foreach (var @char in verification)
                {
                    int index;
                    var isDigit = int.TryParse(@char.ToString(), out index);

                    var isValid = index >= 0 && index < message.Length;

                    if (isDigit && isValid)
                    {
                        var messageChar = message[index];
                        verificationCode += messageChar; 
                    }
                    else
                    {
                        verificationCode += " ";
                    }
                }
                Console.WriteLine($"{message} == {verificationCode}");
                input = Console.ReadLine();
            }
        }
    }
}
