using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _04.ConvertFromBase_10Tobase_N
{
    class ConverFrom10t
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            StringBuilder sb = new StringBuilder();
            long baseN = long.Parse( inputs[0]);
            BigInteger base10 = BigInteger.Parse( inputs[1]);

            while (base10 > 0)
            {
                var currentResult=( base10 % baseN);
                sb.Insert(0, currentResult);
                base10 /= baseN;
            }
            
            Console.WriteLine(sb);
        }
    }
}
