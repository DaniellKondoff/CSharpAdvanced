using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6.ValidUsernames
{
    class ValidUserName
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"^[\w,-]{3,16}$";

            Regex regex = new Regex(pattern,RegexOptions.Multiline);

            while (text != "END")
            {
                MatchCollection matches = regex.Matches(text);
                Match match = regex.Match(text);
                if (matches.Count ==0 || !match.Success)
                {
                    Console.WriteLine("invalid");
                }
                else
                {
                    Console.WriteLine("valid");
                }
                text = Console.ReadLine();
            }
        }
    }
}
