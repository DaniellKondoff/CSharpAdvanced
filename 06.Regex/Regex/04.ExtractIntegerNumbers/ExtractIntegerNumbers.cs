using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.ExtractIntegerNumbers
{
    class ExtractIntegerNumbers
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"[\d]+";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
