using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sets_Of_Elements
{
    class SetsOfElements
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstSet = new SortedSet<int>();
            var secondSet = new SortedSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                int numberN = int.Parse(Console.ReadLine());
                firstSet.Add(numberN);
            }

            for (int i = 0; i < input[1]; i++)
            {
                int numberM = int.Parse(Console.ReadLine());
                secondSet.Add(numberM);
            }

            firstSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ",firstSet));
        }
    }
}
