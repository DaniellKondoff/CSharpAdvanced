using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.LettersChangeNumbers
{
    class Letters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal totalSum = 0;

            foreach (var word in input)
            {
                char firstLetter = word[0];
                var lastLetter = word[word.Length - 1];
                decimal number = decimal.Parse(word.Substring(1,word.Length-2));

                int alphabetPosition = firstLetter % 32;
                if (char.IsUpper(firstLetter))
                {
                    number = number / alphabetPosition;
                }
                else
                {
                   
                    number = number * alphabetPosition;
                }

                alphabetPosition = lastLetter % 32;
                if (char.IsUpper(lastLetter))
                {
                    number = number - alphabetPosition;
                }
                else
                {
                    number = number + alphabetPosition;
                }
                totalSum += number;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
