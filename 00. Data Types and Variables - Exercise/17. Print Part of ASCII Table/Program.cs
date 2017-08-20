using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int secound = int.Parse(Console.ReadLine());

            for (int i = first; i <= secound; i++)
            {
                Console.Write("{0} ", (char)i);
            }
        }
    }
}
