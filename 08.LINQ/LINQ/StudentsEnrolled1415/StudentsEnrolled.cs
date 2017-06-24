using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsEnrolled1415
{
   public  class StudentsEnrolled
    {
        public class Student
        {
            public string FacultyNumber { get; set; }

            public List<int> Marks { get; set; }
        }

        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input != "END")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Student student = new Student();
                student.FacultyNumber = tokens[0];
                student.Marks = new List<int>();
                for (int i = 1; i < tokens.Count; i++)
                {
                    student.Marks.Add(int.Parse(tokens[i]));
                }
                students.Add(student);

                input = Console.ReadLine();
            }

            students.Where(s => s.FacultyNumber.EndsWith("14") || s.FacultyNumber.EndsWith("15"))
                .Select(s => s.Marks)
                .ToList()
                .ForEach(s => Console.WriteLine(string.Join(" ",s)));
        }
    }
}
