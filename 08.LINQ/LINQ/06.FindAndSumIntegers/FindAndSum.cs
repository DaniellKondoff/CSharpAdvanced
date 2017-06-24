using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FindAndSumIntegers
{
    class FindAndSum
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            var sum = input.Split()
                .Select(w =>
                {
                    long value;
                    bool success = long.TryParse(w, out value);
                    return new
                    {
                        value, success
                    };
                })
                .Where(w=>w.success)
                .Select(w=>w.value)
                .ToList();

            if (sum.Count == 0)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine(sum.Sum());
            }
        }
    }
}
