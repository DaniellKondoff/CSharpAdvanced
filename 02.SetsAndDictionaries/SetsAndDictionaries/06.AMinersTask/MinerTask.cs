using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.AMinersTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            var dictMiner = new Dictionary<string, decimal>();

            while (true)
            {
                var resource = Console.ReadLine();
                if (resource == "stop") break;
                var quantity = decimal.Parse(Console.ReadLine());

                if (!dictMiner.ContainsKey(resource))
                {
                    dictMiner.Add(resource, 0);
                }

                dictMiner[resource] += quantity;
 
            }

            foreach (var miner in dictMiner)
            {
                Console.WriteLine($"{miner.Key} -> {miner.Value}");
            }
        }
    }
}
