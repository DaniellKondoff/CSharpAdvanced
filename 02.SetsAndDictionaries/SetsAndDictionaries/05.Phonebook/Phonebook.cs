using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            var phoneBook = new Dictionary<string, string>();
            var input = Console.ReadLine();

            while (input != "search")
            {
                var tokens = input.Split('-');

                if (tokens.Length==2)
                {
                    if (!phoneBook.ContainsKey(tokens[0]))
                    {
                        phoneBook.Add(tokens[0], tokens[1]);
                    }
                    else
                    {
                        phoneBook[tokens[0]] = tokens[1];
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "stop")
            {
                if (phoneBook.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {phoneBook[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }
                input = Console.ReadLine();
            }
        }
    }
}
