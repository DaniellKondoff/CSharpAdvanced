using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSubstringOccurrences
{
    class CountSubstring
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            string subStr = Console.ReadLine().ToLower();

            int counter = 0;
            int index = text.IndexOf(subStr);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(subStr, index + 1 );

            }
            
            Console.WriteLine(counter);
        }
    }
}
