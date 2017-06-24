using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacters
{
    class Unicode
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim().ToCharArray();

            foreach (var item in input)
            {
                Console.Write($"\\u{((int)item).ToString("x4")}");
            }
            Console.WriteLine();
        }
    }
}
