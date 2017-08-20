using System;
using System.Collections.Generic;



namespace _01.Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ');

            int count = 1;

            for (int i = text.Length - 1; i > 0; i--)
            {
                if (text[i] == text[i - 1])
                {
                    count++;

                    if (count == 3)
                    {
                        Console.WriteLine("{0} {0} {0}", text[i]);
                        break;
                    }
                }

                else
                {
                    count = 1;
                }


            }
        }
    }
}
