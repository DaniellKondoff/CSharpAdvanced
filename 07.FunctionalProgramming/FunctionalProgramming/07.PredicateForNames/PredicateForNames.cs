using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PredicateForNames
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToList();

            Predicate<string> isValidLength = str => str.Length <= range;

            foreach (var name in names)
            {
                if (isValidLength(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
