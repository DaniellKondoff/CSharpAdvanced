using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterStudentsByPhone
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }
    }
   public class FilterByPhone
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
                student.Phone = tokens[2];
                students.Add(student);

                input = Console.ReadLine();
            }

            students.Where(s => s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592"))
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
        }
    }
}
