using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountUppercaseWords
{
    class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new string[] { " " },
                 StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> upperCaseChecker = w => w[0] == w.ToUpper()[0];

            words.Where(upperCaseChecker)
                .ToList()
                .ForEach(w => Console.WriteLine(w));                
                
        }
    }
}
