using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string nameInput = Console.ReadLine();
            //string pattern = @"^([A-Z]{1}[a-z]+) ([A-Z][a-z]+)$";
            string pattern = @"\b(?<![A-Z])[A-Z]{1}[a-z]+ \b[A-Z]{1}[a-z]+\b";

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
