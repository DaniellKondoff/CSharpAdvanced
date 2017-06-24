namespace _12.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            var keyDictionary = new Dictionary<string, int>() { { "shards",0}, { "fragments",0 }, {"motes",0 } };
            var junkDictionary = new SortedDictionary<string, int>();
            bool isFull = false;
            string keyWinner = string.Empty;

            while (true)
            {
                var input = Console.ReadLine().ToLower().Split();
                for (int i = 0; i < input.Length; i+=2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i+1];
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        if (!keyDictionary.ContainsKey(material))
                        {
                            keyDictionary[material] = quantity;
                            if (keyDictionary[material] >= 250)
                            {
                                keyDictionary[material] -= 250;
                                keyWinner = material;
                                isFull = true;
                            }
                        }
                        else
                        {
                            keyDictionary[material] += quantity;
                            if (keyDictionary[material] >= 250)
                            {
                                keyDictionary[material] -= 250;
                                keyWinner = material;
                                isFull = true;
                            }
                        }

                    }
                    else
                    {
                        if (!junkDictionary.ContainsKey(material))
                        {
                            junkDictionary[material] = quantity;
                        }
                        else
                        {
                            junkDictionary[material] += quantity;
                        }
                    }

                    if (isFull)
                    {
                        break;
                    }
                }

                if (isFull)
                {
                    break;
                }
            }

            switch (keyWinner)
            {
                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                        break;
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
                default:
                    break;
            }
            foreach (var material in keyDictionary.OrderByDescending(v=>v.Value).ThenBy(v=>v.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var junk in junkDictionary)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}
