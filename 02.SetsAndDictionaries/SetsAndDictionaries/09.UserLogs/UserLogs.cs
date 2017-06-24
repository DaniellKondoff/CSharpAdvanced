using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var logDict = new SortedDictionary<string, Dictionary<string, int>>();

            while (input!="end")
            {
                var tokens = input.Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string ip = tokens[1];
                string userName = tokens[tokens.Length - 1];

                if (!logDict.ContainsKey(userName))
                {
                    logDict.Add(userName, new Dictionary<string, int>());
                }
                if (!logDict[userName].ContainsKey(ip))
                {
                    logDict[userName][ip] = 0;
                }
                logDict[userName][ip]++;
                input = Console.ReadLine();
            }

            foreach (var kvp in logDict)
            {
                Console.WriteLine($"{kvp.Key}:");
                Console.WriteLine("{0}.",string.Join(", ", kvp.Value.Select(x=>$"{x.Key} => {x.Value}")));
            }
        }
    }
}
