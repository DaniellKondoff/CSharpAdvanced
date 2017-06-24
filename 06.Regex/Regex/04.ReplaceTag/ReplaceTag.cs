using System;
using System.Text.RegularExpressions;

namespace _04.ReplaceTag
{
    internal class ReplaceTag
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"<a (href=.+?)>(.+)(<\/a>)";

            Regex regex = new Regex(pattern);

            while (input != "end")
            {
                var result = Regex.Replace(input, pattern.ToString(),
                    @"[URL $1]$2[/URL]");
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}