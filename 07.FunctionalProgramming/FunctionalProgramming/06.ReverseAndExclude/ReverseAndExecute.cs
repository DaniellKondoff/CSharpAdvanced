using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseAndExclude
{
    class ReverseAndExecute
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            var divider = int.Parse(Console.ReadLine());
            
            Predicate<int> isDividable = n => n % divider != 0;
            Action<List<int>> Print = n => Console.WriteLine(string.Join(" ", n));

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (!isDividable(numbers[i]))
                {
                    numbers.Remove(numbers[i]);
                }
            }

            Print(numbers);
        }
    }
}
