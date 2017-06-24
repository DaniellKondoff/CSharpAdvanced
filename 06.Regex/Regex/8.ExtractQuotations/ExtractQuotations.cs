using System;
using System.Text.RegularExpressions;

namespace _8.ExtractQuotations
{
    class ExtractQuotations
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern= @"('|"")(.+?)\1";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
