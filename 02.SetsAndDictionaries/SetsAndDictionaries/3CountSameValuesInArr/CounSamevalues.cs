namespace _3CountSameValuesInArr
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CounSamevalues
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split(new char[] { ' ' },
                                StringSplitOptions.RemoveEmptyEntries)
                               .Select(double.Parse).ToArray();


            SortedDictionary<double, int> dict = new SortedDictionary<double, int>();


            for (int i = 0; i < numbers.Length; i++)
            {
                if (!dict.Keys.Contains(numbers[i]))
                {
                    dict.Add(numbers[i], 1);
                }
                else
                {
                    dict[numbers[i]]++;
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
