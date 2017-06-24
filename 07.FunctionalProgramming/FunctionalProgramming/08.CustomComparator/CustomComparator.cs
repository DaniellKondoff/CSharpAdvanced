using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var resultEven = numbers.Where(num => Filter(num, x => x % 2 == 0)).OrderBy(a=>a);
            var resultOdd = numbers.Where(num => Filter(num, x => x % 2 != 0)).OrderBy(a => a);

            var result = resultEven.Concat(resultOdd);
            Console.WriteLine(string.Join(" ",result));

        }

        private static bool Filter(int num,Func<int,bool> func)
        {
            return func(num);
        }
    }
}
