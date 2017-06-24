using System;
using System.Text.RegularExpressions;

namespace _06.SentenceExtractor
{
    internal class SentenceExtractor
    {
        private static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = $"[^.?!]*(?<=[.?\\s!]){keyWord}(?=[.?\\s!])[^.?!]*[.?!]";
            //[A-Za-z ]+\bis\b.*?[.?!]

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[0].Value);
            }
        }
    }
}