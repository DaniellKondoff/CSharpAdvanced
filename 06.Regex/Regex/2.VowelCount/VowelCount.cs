using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.VowelCount
{
    class VowelCount
    {
        static void Main(string[] args)
        {
            string pattern = "[AEIOUYaeiouy]";
            string text = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            Console.WriteLine($"Vowels: {matches.Count}");

        }
    }
}
