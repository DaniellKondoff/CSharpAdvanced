using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop") break;
                string mail = Console.ReadLine();

                if (!mail.EndsWith("us" ) && !mail.EndsWith("uk"))
                {
                    dict.Add(name, mail);
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
