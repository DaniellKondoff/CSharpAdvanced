using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstName
{
    class FirstName
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();
            var letters = Console.ReadLine().Split().ToList().OrderBy(a=>a);
            string name = string.Empty;

            foreach (var letter in letters)
            {
                name = names.Where(n => n.ToLower().StartsWith(letter.ToLower())).FirstOrDefault();
                if (name != null)
                {
                    break;
                }
            }


            if (name == null) Console.WriteLine("No match");
            else
            {
                Console.WriteLine(name);
            }
        }
    }
}
