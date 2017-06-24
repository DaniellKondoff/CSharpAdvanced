using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CharacterMultiplier
{
    class CharMultiplier
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            int sum = GetSumByStrings(input[0], input[1]);
            Console.WriteLine(sum);
        }

        private static int GetSumByStrings(string str1, string str2)
        {
            int sum = 0;
            if (str1.Length==str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    sum += (str1[i] * str2[i]);
                }
                return sum;
            }
            else
            {
                int minLenght = Math.Min(str1.Length, str2.Length);
                int maxLenght = Math.Max(str1.Length, str2.Length);

                for (int i = 0; i < minLenght; i++)
                {
                    sum += (str1[i] * str2[i]);
                }
                string thirdString;
                if (str1.Length>str2.Length)
                {
                    thirdString = str1;
                }
                else
                {
                    thirdString = str2;
                }
                for (int i = minLenght; i < maxLenght; i++)
                {
                    sum += thirdString[i];
                }
                return sum;
            }
        }
    }
}
