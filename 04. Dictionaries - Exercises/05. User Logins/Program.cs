using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.User_Logins
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var userPass = new Dictionary<string, string>();
            var loginTry = new Dictionary<string, string>();
            var count = 0;

            while (input != "login")
            {
                var tokens = input.Split(" -> ".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);
                var username = tokens[0];
                var pass = tokens[1];

                userPass[username] = pass;

                input = Console.ReadLine();

            }

            input = Console.ReadLine();
            while (input != "end")
            {
                var tokens = input.Split(" -> ".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);
                var username = tokens[0];
                var pass = tokens[1];

                loginTry[username] = pass;

                if (!userPass.ContainsKey(username))
                {
                    Console.WriteLine($"{username}: login failed");
                    count++;
                    
                    
                }

                else if (loginTry[username] == userPass[username])
                {
                    Console.WriteLine($"{username}: logged in successfully");
                    
                }

                else
                {
                    Console.WriteLine($"{username}: login failed");
                    count++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
