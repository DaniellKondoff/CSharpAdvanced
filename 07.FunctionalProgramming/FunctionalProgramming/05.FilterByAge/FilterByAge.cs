using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FilterByAge
{
    class FilterByAge
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> filterDict = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);
                filterDict.Add(input[0], int.Parse(input[1]));
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<int, bool> tester = CreateTester(condition, age);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);

            PrintFilteredStudent(filterDict, tester, printer);
        }

        private static void PrintFilteredStudent(Dictionary<string, int> filterDict, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in filterDict)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }

        private static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return person => Console.WriteLine($"{person.Key}");
                case "age":
                    return person => Console.WriteLine($"{person.Value}");
                case "name age":
                    return person => Console.WriteLine($"{person.Key} - {person.Value}");
                default: return null;
                    
            }
        }

        private static Func<int, bool> CreateTester(string condition, int age)
        {
            switch (condition)
            {
                case "younger":return x => x <= age;
                case "older": return x => x >= age;
                default:return null;
            }
        }
    }
}
