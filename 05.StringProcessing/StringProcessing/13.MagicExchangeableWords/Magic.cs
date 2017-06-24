using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MagicExchangeableWords
{
    class Magic
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            bool isTrue= IsExchegeable(input[0],input[1]);

            //Console.WriteLine(isTrue.ToString().ToLower());

            SecondWayDictionary(input[0], input[1]);
        }

        private static void SecondWayDictionary(string longerStr, string shorterStr)
        {
            Dictionary<char, char> mappedChars = new Dictionary<char, char>();
            bool magic = true;

            if (shorterStr.Length > longerStr.Length)
            {
                var temp = longerStr;
                longerStr = shorterStr;
                shorterStr = temp;
            }
            for (int i = 0; i < shorterStr.Length; i++)
            {
                if (!mappedChars.ContainsKey(longerStr[i]))
                {
                    mappedChars.Add(longerStr[i], shorterStr[i]);
                }
                else if (mappedChars[longerStr[i]] != shorterStr[i])
                {
                    magic = false;
                    break;
                }
            }

            if (magic)
            {
                for (int i = shorterStr.Length; i <longerStr.Length ; i++)
                {
                    if (!mappedChars.ContainsKey(longerStr[i]))
                    {
                        magic = false;
                        break;
                    }
                }
            }
            Console.WriteLine(magic.ToString().ToLower());
        }

        private static bool IsExchegeable(string str1, string str2)
        {
            var firstHashSet = new HashSet<char>();
            for (int i = 0; i < str1.Length; i++)
            {
                firstHashSet.Add(str1[i]);
            }

            var secondHashSet = new HashSet<char>();
            for (int i = 0; i < str2.Length; i++)
            {
                secondHashSet.Add(str2[i]);
            }

            return firstHashSet.Count == secondHashSet.Count;
        }
    }
}
