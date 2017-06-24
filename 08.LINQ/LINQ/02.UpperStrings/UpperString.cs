using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.UpperStrings
{
    class UpperString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();

            input.Select(str => str.ToUpper())
                .ToList()
                .ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
        }
    }
}
