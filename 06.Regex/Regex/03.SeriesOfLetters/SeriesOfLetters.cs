using System;
using System.Text.RegularExpressions;

namespace _03.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Za-z])\1+";

            Console.WriteLine(Regex.Replace(input, pattern, "$1"));
        }
    }
}
