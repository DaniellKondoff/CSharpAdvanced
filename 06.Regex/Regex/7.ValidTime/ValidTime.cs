using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.ValidTime
{
    class ValidTime
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"^([01][0-9]):([0-5][0-9]):([0-5][0-9]) [AP]M$";

            Regex regex = new Regex(pattern, RegexOptions.Multiline);

            while (text != "END")
            {
                MatchCollection matches = regex.Matches(text);
                if (matches.Count == 0)
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
