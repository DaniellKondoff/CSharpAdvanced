using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            SortedSet<string> set = new SortedSet<string>();

            var input = Console.ReadLine().Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var word in input)
            {
                if (word.Length==1)
                {
                    set.Add(word);
                }
                else
                {
                    for (int i = 0; i < word.Length / 2; i++)
                    {
                        if (word[i] == word[word.Length - 1-i])
                        {
                            set.Add(word);
                        }
                        else
                        {
                            set.Remove(word);
                            break;
                        }
                    }
                } 
            }

            Console.WriteLine($"[{string.Join(", ",set)}]");
        }
    }
}
