using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FilterStudentsByEmailDomain
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }

    public class FilterStudents
    {
       public static void Main()
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student();
                student.FirstName = tokens[0];
                student.LastName = tokens[1];
                student.Email = tokens[2];
                students.Add(student);

                input = Console.ReadLine();
            }

            students.Where(s=>s.Email.EndsWith("@gmail.com"))
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }
}
