using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StudentsByAge
{
    class StudentByAge
    {
        static void Main(string[] args)
        {
            string students = Console.ReadLine();
            var filteredStudents = new List<string[]>();

            while (students != "END")
            {
                filteredStudents.Add(students.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                students = Console.ReadLine();
            }

            var result = filteredStudents.Where(s => int.Parse(s[2]) >= 18 && int.Parse(s[2]) <=24 ).ToList();

            foreach (var student in result)
            {
                Console.WriteLine($"{student[0]} {student[1]} {student[2]}");
            }
        }
    }
}
