using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dict = new SortedDictionary<char, int>();

            foreach (var letter in input)
            {
                if (!dict.ContainsKey(letter))
                {
                    dict.Add(letter, 1);
                }
                else
                {
                    dict[letter]++;
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
