using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExcellentStudents
{
    public class ExcellentStudents
    {
        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public List<string> Marks { get; set; }
        }

        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Student student = new Student();
                student.FirstName = tokens[0];
                student.LastName = tokens[1];
                student.Marks = new List<string>();
                for (int i = 2; i < tokens.Count; i++)
                {
                    student.Marks.Add(tokens[i]);
                }
                students.Add(student);

                input = Console.ReadLine();
            }

            students
                .Where(s => s.Marks.Any(m => m.Equals("6")))
                .ToList()
                .ForEach(s=>Console.WriteLine($"{s.FirstName} {s.LastName}"));
           
        }
    }
}
