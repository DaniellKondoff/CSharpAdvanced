using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FormattingNumbers
{
    class FormatingNumbers
    {
        private const int  ColumnWidth= 10;
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' } ,StringSplitOptions.RemoveEmptyEntries );
            int a = int.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);

            StringBuilder sb = new StringBuilder();

            string hexDecimal = a.ToString("X");
            string binaryString = Convert.ToString(a, 2);

            sb.Append('|'+hexDecimal.PadRight(10) +'|');
            sb.Append(binaryString.PadLeft(10,'0').Substring(0,10) + '|');
            sb.Append(b.ToString("0.00").PadLeft(10)+'|');
            sb.Append(c.ToString("0.000").PadRight(10)+ '|');

            Console.WriteLine(sb);
        }

    }
}
