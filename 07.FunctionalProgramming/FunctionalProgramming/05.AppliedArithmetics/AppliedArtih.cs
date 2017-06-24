using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.AppliedArithmetics
{
    class AppliedArtih
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Action<List<int>> Print = n => Console.WriteLine(string.Join(" ",n));
            Func<List<int>, List<int>> addFunc = AddMethod;
            Func<List<int>, List<int>> MultuplyFunc = MultiplyMethod;
            Func<List<int>, List<int>> SubFunc = SubMethod;

            string cmd = Console.ReadLine();

            while (cmd != "end")
            {
                var result = new List<int>();
                switch (cmd)
                {
                    case "add":
                        numbers = ApplyFunc(numbers, x => x + 1);
                        break;
                    case "multiply":
                        numbers = MultuplyFunc(numbers);
                        break;
                    case "subtract":
                        numbers = SubFunc(numbers);
                        break;
                    case "print":
                        Print(numbers);
                        break;
                }
                cmd = Console.ReadLine();
            }

        }

        private static List<int> AddMethod(List<int> numbers)
        {
            var result = new List<int>();
            numbers.ForEach(n => result.Add(n + 1));
            return result;
        }

        private static List<int> MultiplyMethod(List<int> numbers)
        {
            var result = new List<int>();
            numbers.ForEach(n => result.Add(n * 2));
            return result;
        }

        private static List<int> SubMethod(List<int> numbers)
        {
            var result = new List<int>();
            numbers.ForEach(n => result.Add(n - 1));
            return result;
        }

        private static List<int> ApplyFunc(List<int> collection,Func<int,int> func)
        {
            var result = new List<int>();
            foreach (var item in collection)
            {
                result.Add(func(item));
            }
            return result;
        }
    }
}
