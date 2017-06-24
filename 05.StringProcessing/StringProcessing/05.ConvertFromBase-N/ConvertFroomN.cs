using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _05.ConvertFromBase_N
{
    class ConvertFroomN
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int baseN = int.Parse(inputs[0]);
            var digitsChars = inputs[1].ToCharArray();

            BigInteger result = new BigInteger(0);

            int pow = digitsChars.Length-1;

            for (int i = 0; i < digitsChars.Length; i++)
            {
                int currentDigit = (int)char.GetNumericValue(digitsChars[i]);
                result += currentDigit * (BigInteger.Pow(baseN,pow));
                pow--;
            }
            Console.WriteLine(result);

        }
    }
}
