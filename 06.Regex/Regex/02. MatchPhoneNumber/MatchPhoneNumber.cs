using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string nameInput = Console.ReadLine();
            string pattern = @"^\+([359])+(\-|\s)2\2(\d){3}\2(\d){4}$";

            Regex regex = new Regex(pattern);

            while (nameInput != "end")
            {
                Match match = regex.Match(nameInput);
                if (match.Success)
                {
                    Console.WriteLine(nameInput);
                }
                nameInput = Console.ReadLine();
            }
        }
    }
}
