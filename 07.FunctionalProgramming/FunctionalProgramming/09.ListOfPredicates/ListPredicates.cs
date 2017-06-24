using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ListOfPredicates
{
    public static class Predicates
    {
        public static List<Func<int, bool>> predicates = new List<Func<int, bool>>();

        public static void AddPredicate(Func<int,bool> predicate)
        {
            predicates.Add(predicate);
        }

        public static List<int> ApplyPredicates(List<int> numbers)
        {
            var result = new List<int>();
            bool legal = true;
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                foreach (var predicate in predicates)
                {
                    if (!predicate(currentNum))
                    {
                        legal = false;
                        break;
                    }   
                }
                if (legal)
                {
                    result.Add(currentNum);
                }
                legal = true;
            }
            return result;
        }
    }
    public class ListPredicates
    {
       public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers =new  List<int>();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            var divisors = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var divisor in divisors)
            {
                Predicates.AddPredicate(x => x % divisor == 0);
            }
            numbers = Predicates.ApplyPredicates(numbers);

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
