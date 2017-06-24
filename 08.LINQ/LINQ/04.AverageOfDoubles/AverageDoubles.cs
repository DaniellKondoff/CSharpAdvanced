using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageOfDoubles
{
    class AverageDoubles
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).Average();
            Console.WriteLine($"{numbers:f2}");
        }
    }
}
