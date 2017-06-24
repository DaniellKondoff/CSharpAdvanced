using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ThePRFM
{
    class PRFM
    {
        static void Main(string[] args)
        {
            var guestList = Console.ReadLine().Split().ToList();
            var cmd = Console.ReadLine().Split(';');
            var filteredList = new List<string>();

            while (cmd[0].Trim() != "Print")
            {
                string filterCommand = cmd[0].Trim();
                string filterType = cmd[1].Trim();
                string param = cmd[2].Trim();

                if (filterCommand == "Add filter")
                {
                    switch (filterType)
                    {
                        case "Starts with":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i],x=>x.StartsWith(param)))
                                {
                                    guestList[i] = guestList[i].ToLower();
                                }
                            }
                            break;
                        case "Ends with":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], x => x.EndsWith(param)))
                                {
                                    guestList[i] = guestList[i].ToLower();
                                }
                            }
                            break;
                        case "Length":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], x => x.Length==int.Parse(param)))
                                {
                                    guestList[i] = guestList[i].ToLower();
                                }
                            }
                            break;
                        case "Contains":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], x => x.Contains(param)))
                                {
                                    guestList[i] = guestList[i].ToLower();
                                }
                            }
                            break;
                    }
                }
                else if (filterCommand=="Remove filter")
                {
                    switch (filterType)
                    {
                        case "Starts with":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], x => x.StartsWith(param.ToLower())))
                                {
                                    guestList[i] = guestList[i].ToUpperInvariant();
                                }
                            }
                            break;
                        case "Ends with":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], x => x.EndsWith(param.ToLower())))
                                {
                                    guestList[i] = guestList[i].ToUpper();
                                }
                            }
                            break;
                        case "Length":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], x => x.Length == int.Parse(param.ToLower())))
                                {
                                    guestList[i] = guestList[i].ToUpper();
                                }
                            }
                            break;
                        case "Contains":
                            for (int i = guestList.Count - 1; i >= 0; i--)
                            {
                                if (Filter(guestList[i], x => x.Contains(param.ToLower())))
                                {
                                    guestList[i] = guestList[i].ToUpper();
                                }
                            }
                            break;
                    }
                }

                cmd = Console.ReadLine().Split(';');
            }

            foreach (var guest in guestList)
            {
                if (guest[0]==guest.ToUpper()[0])
                {
                    string currentString = guest[0] + guest.Substring(1).ToLower();
                    filteredList.Add(currentString);
                }
            }

            Console.WriteLine( string.Join(" ", filteredList));
        }
        private static bool Filter(string name, Func<string, bool> func)
        {
            return func(name);
        }
    }
}
