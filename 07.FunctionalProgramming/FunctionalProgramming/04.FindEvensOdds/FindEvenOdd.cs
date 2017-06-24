using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindEvensOdds
{
    class FindEvenOdd
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string cmd = Console.ReadLine();

            Predicate<int> isEven = n => n % 2 == 0;

            var evenNum = new List<int>();
            var oddNum = new List<int>();

            for (int i = range[0]; i <= range[1]; i++)
            {
                if (isEven(i))
                {
                    evenNum.Add(i);
                }
                else
                {
                    oddNum.Add(i);
                }
            }

            var param = cmd == "even" ? evenNum : oddNum;
            Console.WriteLine(string.Join(" ",param));
        }

     
             
    }
}
