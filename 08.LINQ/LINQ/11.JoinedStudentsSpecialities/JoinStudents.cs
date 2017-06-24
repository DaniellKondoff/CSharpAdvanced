using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.JoinedStudentsSpecialities
{
    public class JoinStudents
    {
        public class StudentSpecialty
        {
            public string SpecialityName { get; set; }

            public int FacNumber { get; set; }
        }
        public class Student
        {
            public string StudentName { get; set; }

            public int FacNumber { get; set; }
        }
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();
            List<StudentSpecialty> specialities = new List<StudentSpecialty>();

            while (input != "Students:")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                StudentSpecialty speciality = new StudentSpecialty();
                speciality.SpecialityName = tokens[0] + " " + tokens[1];
                speciality.FacNumber = int.Parse(tokens[2]);
                specialities.Add(speciality);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                Student student = new Student();
                student.FacNumber = int.Parse(tokens[0]);
                student.StudentName = tokens[1] + " " + tokens[2];
                students.Add(student);
                input = Console.ReadLine();

            }

            var groupedStudents = from s in students.OrderBy(s => s.StudentName)
                                  join sp in specialities
                                  on s.FacNumber equals sp.FacNumber
                                  select new { s.StudentName, s.FacNumber, sp.SpecialityName };

            foreach (var student in groupedStudents)
            {
                Console.WriteLine($"{student.StudentName} {student.FacNumber} {student.SpecialityName}");
            }
        }
    }
}
