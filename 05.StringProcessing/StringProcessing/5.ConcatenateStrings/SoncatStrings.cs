using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ConcatenateStrings
{
    class SoncatStrings
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                sb.Append(word);
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
