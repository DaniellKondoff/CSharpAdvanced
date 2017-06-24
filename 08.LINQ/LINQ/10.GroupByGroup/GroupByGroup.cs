using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.GroupByGroup
{
    public class GroupByGroup
    {
        public class Person
        {
            public string Name { get; set; }

            public int Group { get; set; }
        }

        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> students = new List<Person>();

            while (input != "END")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Person student = new Person();
                student.Name = tokens[0]+" "+tokens[1];
                student.Group = int.Parse(tokens[2]);
                students.Add(student);

                input = Console.ReadLine();
            }
            var groupedStudents = students.GroupBy(s => s.Group);

            foreach (var group in groupedStudents.OrderBy(s=>s.Key))
            {
                var listResult = new List<string>();
                
                foreach (var person in group)
                {
                    listResult.Add(person.Name);
                }
                                
                Console.WriteLine($"{group.Key} - {string.Join(", ",listResult)}");
            }
        }
    }
}
