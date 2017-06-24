using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _10.UseYourChainsBuddy
{
    internal class Chains
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?:<p>)(.*?)(?:<\/p>)";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            Regex regexForSmallLetters = new Regex("[^a-z0-9]+");
            StringBuilder sb = new StringBuilder();
            foreach (Match match in matches)
            {
                var reminder = match.Groups[1].Value;
                var replaced = Regex.Replace(reminder, regexForSmallLetters.ToString(), " ");
                foreach (var character  in replaced)
                {
                    if (character>='a' && character <='m')
                    {
                        sb.Append((char)(character + 13));
                    }
                    else if (character >= 'n' && character <= 'z')
                    {
                        sb.Append((char)(character - 13));
                    }
                    else
                    {
                        sb.Append(character);
                    }
                }
            }
            var result = Regex.Replace(sb.ToString(), "\\s+", " ");
            Console.WriteLine(result);
        }
    }
}