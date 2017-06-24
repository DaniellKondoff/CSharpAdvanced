using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class PredicateParty
    {
        static void Main(string[] args)
        {
            var guestList = Console.ReadLine().Split().ToList();
            var cmd = Console.ReadLine().Split();

            while (cmd[0] != "Party!")
            {
                if (cmd[0] == "Remove")
                {
                    switch (cmd[1])
                    {
                        case "StartsWith":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], w => w.StartsWith(cmd[2])))
                                {
                                    guestList.Remove(guestList[i]);
                                }
                            }
                            break;
                        case "EndsWith":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], w => w.EndsWith(cmd[2])))
                                {
                                    guestList.Remove(guestList[i]);
                                }
                            }
                            break;
                        case "Length":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], w => w.Length == int.Parse(cmd[2])))
                                {
                                    guestList.Remove(guestList[i]);
                                }
                            }
                            break;

                    }
                }
                else if (cmd[0] == "Double")
                {
                    switch (cmd[1])
                    {
                        case "StartsWith":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], w => w.StartsWith(cmd[2])))
                                {
                                    guestList.Add(guestList[i]);
                                }
                            }
                            break;
                        case "EndsWith":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], w => w.EndsWith(cmd[2])))
                                {
                                    guestList.Add(guestList[i]);
                                }
                            }
                            break;
                        case "Length":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], w => w.Length == int.Parse(cmd[2])))
                                {
                                    guestList.Insert(0, guestList[i]);
                                }
                            }
                            break;
                    }
                }
                cmd = Console.ReadLine().Split();
            }

            if (guestList.Count>0)
            {
                Console.WriteLine($"{string.Join(", ", guestList)} are going to the party!");

            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static bool Filter(string name, Func<string, bool> func)
        {
            return func(name);
        }
    }
}
