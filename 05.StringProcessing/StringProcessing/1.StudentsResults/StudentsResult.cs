using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StudentsResults
{
    class StudentsResult
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format(
                    "{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",
                    "Name", "CAdv", "COOP", "AdvOOP", "Average"
                    ));

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                double cAdv = double.Parse(input[1]);
                double cOop = double.Parse(input[2]);
                double advOop = double.Parse(input[3]);
                double average = cAdv + cOop + advOop;

                Console.WriteLine(string.Format(
                    "{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",
                    name, cAdv, cOop, advOop, (average / 3)
                    ));
            }
            
        }
    }
}
