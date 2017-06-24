using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MinEvenNumber
{
    class MinEveerNumber
    {
        static void Main(string[] args)
        {
            var minNumber = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .Where(n => n % 2 == 0)
                .ToList();
                 

            if (minNumber.Count==0)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine($"{minNumber.Min():f2}");

            }

        }
    }
}
