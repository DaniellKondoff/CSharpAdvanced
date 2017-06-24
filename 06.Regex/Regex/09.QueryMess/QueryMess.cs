using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([^&?]+?)=([^&?]+?)(?=&|$)";
            //string pattern = @"(^\?)*([<>\[\]{}\;\-)(\^$\`\~#\:\/.\+%20\w+\d+]+)\s*=\s*([<>\[\]{}\;\-)\^$\`\~#\:\/.\+%20\w+\d+]+)";
            string spacePattern = @"[\+]*(?:%20)[\+]*|[\+]";
            Regex regex = new Regex(pattern);

            while (input != "END")
            {
                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
                MatchCollection matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    string keyWord =(match.Groups[2].Value);
                    string valueWord=(match.Groups[3].Value);
                    keyWord = Regex.Replace(keyWord, spacePattern, " ").Trim();
                    valueWord = Regex.Replace(valueWord, spacePattern, " ").Trim();
                    keyWord = Regex.Replace(keyWord, @"[\s*]+", " ").Trim();
                    valueWord = Regex.Replace(valueWord, @"[\s*]+", " ").Trim();

                    if (!dict.ContainsKey(keyWord))
                    {
                        dict.Add(keyWord,new List<string>() {valueWord});
                    }
                    else
                    {
                        dict[keyWord].Add(valueWord);
                    }
                }
                PrintResult(dict);
                input = Console.ReadLine();
            }

        }

        private static void PrintResult(Dictionary<string, List<string>> dict)
        {
            foreach (var kvp in dict)
            {
                Console.Write($"{kvp.Key}=[{string.Join(", ",kvp.Value)}]");
            }
            Console.WriteLine();
        }
    }
}
