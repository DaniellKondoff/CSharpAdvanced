using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CubicAssault
{
    class Assault
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> meteorDict = new Dictionary<string, long>() { { "Red", 0 }, { "Green", 0 }, { "Black", 0 } };
            string[] allMeteors = new string[] { "Red", "Green", "Black" };

            var dict = new Dictionary<string, Dictionary<string,long>>();
            const long MaxCount = 1000000;

            string input = Console.ReadLine();

            while (input != "Count em all")
            {
                var line = input.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string region = line[0];
                string meteorType = line[1].Trim();
                long count = long.Parse(line[2]);

                if (!dict.ContainsKey(region))
                {
                    dict.Add(region,  new Dictionary<string, long>());
                    dict[region].Add("Green", 0);
                    dict[region].Add("Red", 0);
                    dict[region].Add("Black", 0);
                }
                dict[region][meteorType] += count;


                if (dict[region]["Green"] >=MaxCount)
                {
                    dict[region]["Red"] += dict[region]["Green"] / MaxCount;
                    dict[region]["Green"] %= MaxCount;
                }
                if (dict[region]["Red"] >= MaxCount)
                {
                    dict[region]["Black"] += dict[region]["Red"] / MaxCount;
                    dict[region]["Red"] %= MaxCount;
                }

                input = Console.ReadLine();
            }


           
            
            foreach (var kvp in dict.OrderByDescending(k=>k.Value["Black"]).ThenBy(k=>k.Key.Length).ThenBy(k=>k.Key))
            {
                Console.WriteLine(kvp.Key.Trim());
                
                foreach (var meteor in kvp.Value.OrderByDescending(v=>v.Value).ThenBy(v=>v.Key))
                {
                    Console.WriteLine($"-> {meteor.Key} : {meteor.Value}");
                    
                }              
            }


            //Console.WriteLine();
        }
    }
}
