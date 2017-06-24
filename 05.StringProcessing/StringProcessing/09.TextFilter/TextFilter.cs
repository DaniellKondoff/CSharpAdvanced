using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text = Console.ReadLine();
            var pattern = '*';
            
            foreach (var word in bannedWords)
            {
                text = text.Replace(word, new string(pattern, word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
