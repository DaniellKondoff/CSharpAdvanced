using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ParseURLs
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries);
            

            if (input.Length != 2 || input[1].IndexOf('/') == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            else
            {
                string protocol = input[0];

                int indexOfServer = input[1].IndexOf("/");

                string serverName = input[1].Substring(0, indexOfServer);
                string resources = input[1].Substring(indexOfServer + 1);

                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {serverName}");
                Console.WriteLine($"Resources = {resources}");

            }

        }
    }
}
