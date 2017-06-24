using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Demo
    {
        static void Main()
        {
            //Sets
            //HashSet
            //HashSet<int> set = new HashSet<int>();
            //set.Add(1);
            //set.Add(1);
            //set.Add(2);
            //set.Add(5);
            //set.Add(1);
            //Console.WriteLine(set.Count);
            //Console.WriteLine(set.Contains(1));
            //set.Remove(1);
            //Console.WriteLine(set.Count);
            //Console.WriteLine(set.Contains(1));

            //foreach (var item in set)
            //{
            //    Console.WriteLine(item);
            //}

            //SprtedSet
            //SortedSet<int> sortedSet = new SortedSet<int>();
            //sortedSet.Add(1);
            //sortedSet.Add(1);
            //sortedSet.Add(100);
            //sortedSet.Add(2);
            //sortedSet.Add(1);

            //Console.WriteLine(sortedSet.Count);
            //Console.WriteLine(sortedSet.Max);//Min

            //foreach (var item in sortedSet)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary
            //Dictionary<string, int> dict = new Dictionary<string, int>();
            //dict["Pesho"] = 6;
            //dict["Gosho"] = 3;
            //dict["Ivan"] = 5;

            //Console.WriteLine(dict["Pesho"]);

            //dict.Add("Alice", 3);

            //dict.Remove("Ivan");

            //bool hasPesho = dict.ContainsKey("Pesho");
            //Console.WriteLine(hasPesho);

            //var keys = dict.Keys;
            //var values = dict.Values;

            //foreach (var item in keys)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var kvp in dict)
            //{
            //    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            //}

            //SortedDictionary
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();
            dict["Pesho"] = 6;
            dict["Gosho"] = 3;
            dict["Ivan"] = 5;
            dict["aaaa"] = 4;

            

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }

            int expectedvalue;
            if (dict.TryGetValue("mariq", out expectedvalue))
            {
                Console.WriteLine(expectedvalue);
            }
            else
            {
                Console.WriteLine("no Value");
            }
            
        }
    }
}
