using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Inferno
{
    class Inferno
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Insert(0, 0);
            numbers.Add(0);
            var cmd = Console.ReadLine().Split(';');

            Dictionary<int, bool> dict = new Dictionary<int, bool>();

            while (cmd[0] != "Forge")
            {
                string command = cmd[0];
                string filterType = cmd[1];
                int filterParam = int.Parse(cmd[2]);

                if (command == "Exclude")
                {
                    switch (filterType)
                    {
                        case "Sum Left":
                            for (int i = 1; i < numbers.Count - 1; i++)
                            {
                                if (numbers[i] + numbers[i - 1] == filterParam)
                                {
                                    if (!dict.ContainsKey(numbers[i]))
                                    {
                                        dict.Add(numbers[i], true);
                                    }
                                    dict[numbers[i]] = false;
                                }
                                else
                                {
                                    if (!dict.ContainsKey(numbers[i]))
                                    {
                                        dict.Add(numbers[i], true);
                                    }
                                    //dict[numbers[i]] = true;
                                }
                            }
                            break;
                        case "Sum Right":
                            for (int i = 1; i < numbers.Count - 1; i++)
                            {
                                if (numbers[i] + numbers[i + 1] == filterParam)
                                {
                                    if (!dict.ContainsKey(numbers[i]))
                                    {
                                        dict.Add(numbers[i], false);
                                    }
                                    dict[numbers[i]] = false;
                                }
                                else
                                {
                                    if (!dict.ContainsKey(numbers[i]))
                                    {
                                        dict.Add(numbers[i], true);
                                    }
                                    //dict[numbers[i]] = true;
                                }
                            }
                            break;
                        case "Sum Left Right":
                            for (int i = 1; i < numbers.Count-1; i++)
                            {
                                if (numbers[i-1] + numbers[i] + numbers[i + 1] == filterParam)
                                {
                                    if (!dict.ContainsKey(numbers[i]))
                                    {
                                        dict.Add(numbers[i], false);
                                    }
                                    dict[numbers[i]] = false;
                                }
                                else
                                {
                                    if (!dict.ContainsKey(numbers[i]))
                                    {
                                        dict.Add(numbers[i], true);
                                    }
                                    //dict[numbers[i]] = true;
                                }
                            }
                            break;
                    }
                }
                else if (command=="Reverse")
                {
                    switch (filterType)
                    {
                        case "Sum Left":
                            for (int i = 1; i < numbers.Count - 1; i++)
                            {
                                if (numbers[i] + numbers[i - 1] == filterParam)
                                {                                 
                                    dict[numbers[i]] = true;
                                }
                            }
                            break;
                        case "Sum Right":
                            for (int i = 1; i < numbers.Count - 1; i++)
                            {
                                if (numbers[i] + numbers[i + 1] == filterParam)
                                {

                                    dict[numbers[i]] = true;
                                }
                               
                            }
                            break;
                        case "Sum Left Right":
                            for (int i = 1; i < numbers.Count - 1; i++)
                            {
                                if (numbers[i - 1] + numbers[i] + numbers[i + 1] == filterParam)
                                {
                                    dict[numbers[i]] = true;
                                }
                               
                            }
                            break;
                    }
                }
                cmd = Console.ReadLine().Split(';');
            }

            var result = dict.Where(k => k.Value == true).Select(k=>k.Key);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
