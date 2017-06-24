using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.ExtractHyperlinks
{
    class ExtractHyperlinks
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            string pattern = @"<a\s+[^>]*href\s*=(.*?)>.*?<\s*\/\s*a\s*>";

            while (line != "END")
            {
                sb.Append(line).Append(" ");
                line = Console.ReadLine();
            }

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(sb.ToString());

            foreach (Match match in matches)
            {
                string candidatehref = match.Groups[1].ToString().Trim();
                if (candidatehref[0]=='"')
                {
                    Console.WriteLine(candidatehref.Split(new[] { '"' }, StringSplitOptions.RemoveEmptyEntries).First());
                }
                else if (candidatehref[0] == '\'')
                {
                    Console.WriteLine(candidatehref.Split(new[] { '\'' }, StringSplitOptions.RemoveEmptyEntries).First());
                }
                else
                {
                    Console.WriteLine(Regex.Split(candidatehref,@"\s+").First());
                }
            }
        }
    }
}
