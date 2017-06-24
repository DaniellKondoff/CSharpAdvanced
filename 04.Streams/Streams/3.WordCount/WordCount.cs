using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllText("words.txt").ToLower().Trim().Split(new[] { '\r' ,'\n' }).ToArray();
            var text = File.ReadAllText("text.txt").ToLower().Split(new[] { ' ','-','?','.',',','!','"','\'','\r','\n' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var dict = new Dictionary<string, int>();

            for (int j=0; j<words.Length; j++)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (words[j]==text[i])
                    {
                        if (!dict.ContainsKey(words[j]))
                        {
                            dict.Add(words[j], 0);
                        }
                        dict[words[j]]++;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("result.txt"))
            {
                foreach (var word in dict.OrderByDescending(v=>v.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
