using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Stateless
{
    public class Stateless
    {
        public static void Main()
        {
            string states = Console.ReadLine();

            string result = string.Empty;

            while (states != "collapse")
            {
                string fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    if (states.Contains(fiction))
                    {
                        states = states.Replace(fiction, "");
                    }
                    else
                    {
                        fiction = fiction.Remove(0, 1);
                        if (fiction.Length > 0)
                        {
                            fiction = fiction.Remove(fiction.Length - 1);
                        }
                    }
                }
                if (states.Length > 0)
                {
                    Console.WriteLine(states.Trim());
                }
                else
                {
                    Console.WriteLine("(void)");
                }

                states = Console.ReadLine();
            }
        }
    }
}
