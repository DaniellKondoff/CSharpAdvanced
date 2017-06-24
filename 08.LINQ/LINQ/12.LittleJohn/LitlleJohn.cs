using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.LittleJohn
{
    class LitlleJohn
    {
        static void Main(string[] args)
        {
            var pattern = @"(>----->)|(>>----->)|(>>>----->>)";
            var regex = new Regex(pattern);
            int smallCount = 0;
            int mediumCount = 0;
            int largeCount = 0;

            for (int i = 0; i < 4; i++)
            {
                var match = regex.Match(Console.ReadLine());

                while (match.Success)
                {
                    if (!match.Groups[1].Value.Equals(""))
                    {
                        smallCount++;
                    }
                    else if (!match.Groups[2].Value.Equals(""))
                    {
                        mediumCount++;
                    }
                    else if (!match.Groups[3].Value.Equals(""))
                    {
                        largeCount++;
                    }
                    match = match.NextMatch();
                }
 
            }

            string allCount = $"{smallCount}{mediumCount}{largeCount}";
            int allCountParsed = int.Parse(allCount);
            string binaryResult = Convert.ToString(allCountParsed, 2);
            var reversedBinaryResult = binaryResult.Reverse();
            foreach (var revers in reversedBinaryResult)
            {
                binaryResult += revers;
            }
            Console.WriteLine(Convert.ToInt32(binaryResult, 2));
        }
    }
}
