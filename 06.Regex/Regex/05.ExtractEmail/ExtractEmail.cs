using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.ExtractEmail
{
    class ExtractEmail
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?:^|\s)((?:[a-zA-Z0-9]+[.\-_])*[a-zA-Z0-9]+@(?:[a-zA-Z]+-?)+(?:\.[a-zA-Z]+)+)(?:\.\s)?";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match mathc in matches)
            {
                Console.WriteLine(mathc.Groups[1].Value);
            }
        }
    }
}
