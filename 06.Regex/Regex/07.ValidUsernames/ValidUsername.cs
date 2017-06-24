using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.ValidUsernames
{
    class ValidUsername
    {
        static void Main(string[] args)
        {
            var validUsernames = Console.ReadLine()
                .Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w=>Regex.IsMatch(w,@"\b[a-zA-Z][\w]{2,24}\b"))
                .ToArray();

            int maxSum = 0;
            string firstStr = String.Empty;
            string secondStr = String.Empty;

            for (int i = 1; i < validUsernames.Length; i++)
            {
                int currentSum = validUsernames[i - 1].Length + validUsernames[i].Length;
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    firstStr = validUsernames[i - 1];
                    secondStr = validUsernames[i];
                }
            }

            Console.WriteLine(string.Join("\n",firstStr,secondStr));
        }
    }
}
