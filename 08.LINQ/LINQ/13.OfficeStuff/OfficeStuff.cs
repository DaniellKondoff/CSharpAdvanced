using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.OfficeStuff
{
    class OfficeStuff
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var officeDict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Trim();
                var filteredLine = input.Substring(1, input.Length - 2).Split(new[] {" - " },StringSplitOptions.RemoveEmptyEntries);
                string company = filteredLine[0];
                string product = filteredLine[2];
                int amount = int.Parse(filteredLine[1]);

                if (!officeDict.ContainsKey(company))
                {
                    officeDict.Add(company, new Dictionary<string, int>());
                    officeDict[company].Add(product, amount);
                }
                
                else
                {
                    if (!officeDict[company].ContainsKey(product))
                    {
                        officeDict[company].Add(product, amount);
                    }
                    else
                    {
                        officeDict[company][product] += amount;
                    }
                }
            }

            foreach (var company in officeDict.OrderBy(c=>c.Key))
            {
                List<string> kvpList = new List<string>();
                Console.Write($"{company.Key}: ");
                foreach (var kvp in company.Value)
                {
                    kvpList.Add($"{kvp.Key}-{kvp.Value}");
                }
                Console.WriteLine(string.Join(", ",kvpList));
            }
            
        }
    }
}
