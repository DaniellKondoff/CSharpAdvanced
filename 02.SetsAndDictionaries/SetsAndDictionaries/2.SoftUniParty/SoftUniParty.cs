namespace _2.SoftUniParty
{
    using System;
    using System.Collections.Generic;

    public class SoftUniParty
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedSet<string> guestSet = new SortedSet<string>();

            while (input != "PARTY")
            {
                guestSet.Add(input);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                guestSet.Remove(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(guestSet.Count);
            foreach (var guest in guestSet)
            {
                Console.WriteLine(guest);
            }
        }
    }
}