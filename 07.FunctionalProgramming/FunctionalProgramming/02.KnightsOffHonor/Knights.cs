using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KnightsOffHonor
{
    class Knights
    {
        static void Main(string[] args)
        {
            Action<string> Print = s => Console.WriteLine($"Sir {s}");
            var input = Console.ReadLine().Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries).ToList();
            input.ForEach(Print);

            Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(Print);
        }
    }
}
