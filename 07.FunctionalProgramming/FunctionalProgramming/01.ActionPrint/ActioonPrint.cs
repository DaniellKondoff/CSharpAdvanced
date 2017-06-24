using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ActionPrint
{
    class ActioonPrint
    {
        static void Main(string[] args)
        {
            Action<string> Print = s => Console.WriteLine(s);
            var input = Console.ReadLine().Split().ToList();
            input.ForEach(Print);

        }
    }
}
