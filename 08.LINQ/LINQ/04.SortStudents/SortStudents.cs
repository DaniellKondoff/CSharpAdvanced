using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortStudents
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class SortStudents
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student();
                student.FirstName = tokens[0];
                student.LastName = tokens[1];
                students.Add(student);

                input = Console.ReadLine();
            }

            students.OrderBy(s => s.LastName)
                .ThenByDescending(s => s.FirstName)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }
}
