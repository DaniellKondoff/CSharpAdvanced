using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsByFirstAndLastName
{
    class StudentsName
    {
        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }
        }

        static void Main(string[] args)
        {
            //string students = Console.ReadLine();
            //var filteredStudents = new List<string[]>();

            //while (students != "END")
            //{
            //    filteredStudents.Add(students.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            //    students = Console.ReadLine();
            //}

            //var result = filteredStudents.Where(s => s[0].CompareTo(s[1]) < 0).ToList();

            //foreach (var student in result)
            //{
            //    Console.WriteLine($"{student[0]} {student[1]}");
            //}

            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student();
                student.FirstName = tokens[0];
                student.LastName = tokens[1];
                students.Add(student);

                input = Console.ReadLine();
            }

            students.Where(s => s.FirstName[0].CompareTo(s.LastName[0]) <=0)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }
}
