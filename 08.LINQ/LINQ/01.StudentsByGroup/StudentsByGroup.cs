using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StudentsByGroup
{
    class StudentsByGroup
    {
        static void Main(string[] args)
        {
            var students = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            List<string> groupedStudents = new List<string>();

            while (students[0] != "END")
            {
                if (students[2].Equals("2"))
                {
                    var student = students[0] + " " + students[1];
                    groupedStudents.Add(student);
                }
                students = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join("\n",groupedStudents.OrderBy(a=>a)));
        }
    }
}
