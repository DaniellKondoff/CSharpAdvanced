using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AddVAT
{
    class AddVAT
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split(new string[] { ", " },
                 StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .ToList()
                 .ForEach(n => Console.WriteLine($"{n * 1.20:f2}"));
        }
    }
}
