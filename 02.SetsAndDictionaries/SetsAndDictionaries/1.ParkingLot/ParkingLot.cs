using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.ParkingLot
{
    internal class ParkingLot
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries) //Regex.Split()
                .ToArray();

            var hasSet = new SortedSet<string>();

            while (input[0] != "END")
            {
                if (input[0] == "IN")
                {
                    hasSet.Add(input[1]);
                }
                else
                {
                    hasSet.Remove(input[1]);
                }
                input = Console.ReadLine()
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            if (hasSet.Count != 0)
            {
                foreach (var car in hasSet)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}