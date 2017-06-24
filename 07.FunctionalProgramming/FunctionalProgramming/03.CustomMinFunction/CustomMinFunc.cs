using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CustomMinFunction
{
    class CustomMinFunc
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> customMinFunc = GetMinNumber;
            Console.WriteLine(customMinFunc(numbers));

            //Func<int[], int> customMaxFunc = arg => arg.Max();

            //Console.WriteLine(customMaxFunc(Console.ReadLine()
            //    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray()));
        }

        private static int GetMinNumber(int[] numbers)
        {
            return numbers.Min();
        }
    }
}
