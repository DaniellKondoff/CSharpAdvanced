using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            var samoStudent = new Student
            {
                FirstName = "Pesho",
                LastName = "Goshov",
                Mark = 5,
                DateOfBirth = new DateTime(2000, 1, 5)
            };

            var listOfStudents = new List<Student>()
            {
                        new Student
                    {
                        Id=1,
                        FirstName = "Ivan",
                        LastName = "Ivanov",
                        Mark = 2,
                        DateOfBirth = new DateTime(1989, 1, 5)
                    },
                    new Student
                    {
                        Id=2,
                        FirstName = "Mrtin",
                        LastName = "Martinov",
                        Mark = 10,
                        DateOfBirth = new DateTime(1500, 1, 5)
                    },
                    new Student
                    {
                        Id=3,
                        FirstName = "Mrtin",
                        LastName = "hahahaha",
                        Mark = 10,
                        DateOfBirth = new DateTime(1500, 1, 5)
                    },
                    new Student
                    {

                        Id=4,
                        FirstName = "Mrtin",
                        LastName = "Peshev",
                        Mark = 10,
                        DateOfBirth = new DateTime(1500, 1, 5)
                    },
                    new Student
                    {
                        Id=5,
                        FirstName = "Pesho",
                        LastName = "Goshov",
                        Mark = 5,
                        DateOfBirth = new DateTime(2000, 1, 5)
                    }
        };

            var studentWithA = listOfStudents.Where(st => st.FirstName.Contains('a')).ToList();

            //Grouping
            var groupedEelemens = listOfStudents
                .GroupBy(st => st.FirstName)
                .ToList();

            foreach (var group in groupedEelemens)
            {
                Console.WriteLine(group.Key);

                foreach (var item in group)
                {
                    Console.WriteLine("-- " + item.FirstName + " " + item.LastName);
                }
            }

            //ToDIctionary
            var elementToDict = listOfStudents
                .ToDictionary(st => st.Id);
            var elementToDict1 = listOfStudents
                .ToDictionary(st => st.Id,st=>st.FirstName);

            var dict = listOfStudents
                .GroupBy(st => st.FirstName)
                .ToDictionary(gr => gr.Key);

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
                foreach (var subItem in item.Value)
                {
                    Console.WriteLine("---- "+subItem.LastName);
                }
            }

            var count = listOfStudents.Count(x => x.FirstName.StartsWith("M"));
            Console.WriteLine(count);

            //SelectMany
            var listNumberArrays = new List<int[]>();
            listNumberArrays.Add(new int[] { 1, 2, 3 });
            listNumberArrays.Add(new int[] { 5, 6, 7 });
            listNumberArrays.Add(new int[] { 8, 9, 4 });

            var resultMany= listNumberArrays.SelectMany(s => s).ToList();
            resultMany.ForEach(x => Console.WriteLine(x));

            //JOIN

            Console.WriteLine();
        }
    }
}
