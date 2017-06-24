using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public static class CollectionExstension
    {
        public static string TrimDashes(this string input)
        {
            return input.Trim('-');
        }

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }

            return collection;
        }

        public static IEnumerable<T> Filter<T>( this IEnumerable<T> numbers, Func<T, bool> filter)
        {
            var result = new List<T>();
            foreach (var number in numbers)
            {
                if (filter(number))
                {
                    result.Add(number);
                }
            }
            return result;
        }
    }
}
