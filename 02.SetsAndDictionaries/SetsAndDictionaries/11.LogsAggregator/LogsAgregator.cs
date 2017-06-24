using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.LogsAggregator
{
    class LogsAgregator
    {
        static void Main(string[] args)
        {
            var logDict = new SortedDictionary<string, SortedDictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string userName = input[1];
                string ip = input[0];
                long duration = long.Parse(input[2]);

                if (!logDict.ContainsKey(userName))
                {
                    logDict.Add(userName, new SortedDictionary<string, long>());
                }
                if (!logDict[userName].ContainsKey(ip))
                {
                    logDict[userName][ip] = duration;
                }
                else
                {
                    logDict[userName][ip] += duration;
                }

            }

            foreach (var logs in logDict)
            {
                Console.WriteLine($"{logs.Key}: {logs.Value.Values.Sum()} [{string.Join(", ",logs.Value.Select(v=>v.Key))}]");
            }
        }
    }
}
