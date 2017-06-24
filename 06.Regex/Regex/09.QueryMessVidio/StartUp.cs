using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.QueryMessVidio
{
    class StartUp
    {
        static Dictionary<string, List<string>> kvp = new Dictionary<string, List<string>>();

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string whiteSpacePatternOne = @"(?:\+|%20)+";
            string whiteSpacePatternTwo = @"\s+";

            while (input != "END")
            {
                input = Regex.Replace(input, whiteSpacePatternOne, " ");
                input = Regex.Replace(input, whiteSpacePatternTwo, " ");
                string[] pairs = input.Split('&');
                DecodePairs(pairs);

                foreach (var k in kvp)
                {
                    Console.Write($"{k.Key}=[{string.Join(", ", k.Value)}]");
                }

                Console.WriteLine();
                kvp.Clear();
                input = Console.ReadLine();

            }
        }

        private static void DecodePairs(string[] pairs)

        {
            foreach (var pair in pairs)
            {
                string properString = pair;
                int indexOfSeparator = pair.IndexOf('?');
                if (indexOfSeparator != -1)
                {
                    properString = properString.Substring(indexOfSeparator+1);
                }
                string[] splitPair = properString.Split('=');
                string key = splitPair[0].Trim();
                string value = splitPair[1].Trim();

                if (!kvp.ContainsKey(key))
                {
                    kvp.Add(key, new List<string>());
                }
                kvp[key].Add(value);
            }
        }
    }
}
