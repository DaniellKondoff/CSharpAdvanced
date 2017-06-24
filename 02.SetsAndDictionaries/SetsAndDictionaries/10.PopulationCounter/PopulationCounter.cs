using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var popDict = new Dictionary<string, Dictionary<string, decimal>>();

            while (input != "report")
            {
                var tokens = input.Split('|');
                string cauntry = tokens[1];
                string city = tokens[0];
                decimal population = decimal.Parse(tokens[2]);

                if (!popDict.ContainsKey(cauntry))
                {
                    popDict[cauntry] = new Dictionary<string, decimal>();
                }
                if (!popDict[cauntry].ContainsKey(city))
                {
                    popDict[cauntry][city] = 0;
                }
                popDict[cauntry][city] = population;
                input = Console.ReadLine();
            }

            foreach (var country in popDict.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                decimal totalPopulation = 0;
                var countryName = country.Key;
                var cities = country.Value;
                foreach (var city in cities)
                {
                    totalPopulation += city.Value;
                }
                Console.WriteLine($"{countryName} (total population: {totalPopulation})");
                foreach (var item in cities.OrderByDescending(c=>c.Value))
                {
                    Console.WriteLine($"=>{item.Key}: {item.Value}");
                }
            }

            
        }
    }
}
