using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubicArtillery
{
    class CubicArtillery
    {
        static void Main(string[] args)
        {
            var maxCapacity = int.Parse(Console.ReadLine());
            var bunkers = new Queue<string>();
            var weapons = new Queue<int>();
            var leftCapacity = maxCapacity;

            string inputLine = Console.ReadLine();
            while (inputLine !="Bunker Revision")
            {
                var tokens = inputLine.Split(' ');
                foreach (var token in tokens)
                {
                    int weapon;
                    var isDigit = int.TryParse(token, out weapon);
                    if (!isDigit)
                    {
                        bunkers.Enqueue(token);
                    }
                    else
                    {
                        var isSaved = false;
                        while (bunkers.Count >1)
                        {
                            if (leftCapacity >= weapon)
                            {
                                weapons.Enqueue(weapon);
                                leftCapacity -= weapon;
                                isSaved = true;
                                break;
                            }

                            var removedBunker = bunkers.Dequeue();
                            if (weapons.Count == 0)
                            {
                                Console.WriteLine($"{removedBunker} -> Empty");
                            }
                            else
                            {
                                Console.WriteLine($"{removedBunker} -> {string.Join(", ",weapons)}");
                            }

                            weapons.Clear();
                            leftCapacity = maxCapacity;
                        }

                        if (!isSaved)
                        {
                            if (weapon <= maxCapacity)
                            {
                                while (leftCapacity < weapon)
                                {
                                   leftCapacity += weapons.Dequeue();
                                }
                                weapons.Enqueue(weapon);
                                leftCapacity -= weapon;

                            }
                        }
                    }

                }
                inputLine = Console.ReadLine();
            }
        }
    }
}
