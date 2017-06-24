using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split();

                foreach (var element in elements)
                {
                    set.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ",set));
        }
    }
}
