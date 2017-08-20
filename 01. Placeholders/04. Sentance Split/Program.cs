using System;
using System.Collections.Generic;
using System.Linq;


namespace Sentance_Split
{
    class Program
    {
        static void Main()
        {

            var sentence = Console.ReadLine();
            var delimeter = Console.ReadLine();
            var result = sentence.Split(new string[] { delimeter }, StringSplitOptions.None).ToList();

            Console.WriteLine($"[{string.Join(", ", result)}]");
        }
    }
}
