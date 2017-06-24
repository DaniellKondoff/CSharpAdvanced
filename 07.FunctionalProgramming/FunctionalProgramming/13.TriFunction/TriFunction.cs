using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TriFunction
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToArray();

            Func<int, string, bool> Trifunction = isValidName;

            foreach (var name in names)
            {
                if (Trifunction(n,name))
                {
                    Console.WriteLine(name);
                    break;
                }
            }
        }

        public static bool isValidName(int number,string name)
        {
            var nameAsChar = name.ToCharArray();
            int currentSum = 0;
            for (int i = 0; i < nameAsChar.Length; i++)
            {
                currentSum += (int)(nameAsChar[i]);
            }
            if (currentSum < number)
            {
                return false;
            }
            return true;
        }
    }
}
