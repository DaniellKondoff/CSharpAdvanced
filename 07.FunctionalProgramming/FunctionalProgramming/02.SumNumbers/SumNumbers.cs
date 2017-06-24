using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine();
            Func<string, int> intParser = n => int.Parse(n);

            Console.WriteLine(numbers
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(intParser)
                .Count());
            Console.WriteLine(numbers
                .Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries)
                .Select(intParser)
                .Sum());
        }
    }
}
