using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BoundedNumbers
{
    class BoundedNumbers
    {
        static void Main(string[] args)
        {
            var bounders = Console.ReadLine().Split().Select(int.Parse);
            int lowerBound = bounders.Min();
            int upperBound = bounders.Max();

            var numbers = Console.ReadLine().Split()
                .Select(int.Parse)
                .Where(n => n >= lowerBound && n <= upperBound)
                .ToList();

            Console.WriteLine(string.Join(" ",numbers));
                
        }
    }
}
