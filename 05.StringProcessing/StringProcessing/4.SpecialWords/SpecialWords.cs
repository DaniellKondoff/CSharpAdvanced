using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SpecialWords
{
    class SpecialWords
    {
        static void Main(string[] args)
        {
            var specialWords = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text= Console.ReadLine()
                .Split(new[] { ' ','(',')','[',']','<','>',',','-','!','?','\'','`' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var dict = new Dictionary<string, int>();

            foreach (var word in specialWords)
            {
                dict.Add(word, 0);
                foreach (var w in text)
                {
                    if (word.Equals(w))
                    {
                        if (dict.ContainsKey(word))
                        {
                            dict[word]++;
                        }
                    }
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
