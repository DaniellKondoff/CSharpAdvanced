using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.AshesRoses
{
    class AshesRoses
    {
        static void Main(string[] args)
        {
            string pattern = @"^Grow <(?<region>[A-Z][a-z]+)> <(?<color>[A-Za-z0-9]+)> (?<amount>\d+)$";
            Regex regex = new Regex(pattern);

            var regionsInfo = new Dictionary<string, Dictionary<string, long>>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Icarus, Ignite!")
            {
                var match = regex.Match(inputLine);

                if (!match.Success)
                {
                    continue;
                }

                var regionName = match.Groups["region"].Value;
                var colorName = match.Groups["color"].Value;
                var amount = int.Parse(match.Groups["amount"].Value);

                if (!regionsInfo.ContainsKey(regionName))
                {
                    regionsInfo.Add(regionName, new Dictionary<string, long>());
                }
                if (!regionsInfo[regionName].ContainsKey(colorName))
                {
                    regionsInfo[regionName].Add(colorName, 0);
                }
                regionsInfo[regionName][colorName] += amount;
            }

            foreach (var region in regionsInfo.OrderByDescending(r=>r.Value.Values.Sum()).ThenBy(r=>r.Key))
            {
                Console.WriteLine(region.Key);
                foreach (var colorAmountPairl in region.Value.OrderBy(cl=>cl.Value).ThenBy(cl=>cl.Key))
                {
                    Console.WriteLine($"*--{colorAmountPairl.Key} | {colorAmountPairl.Value}");
                }
            }
        }
    }
}
