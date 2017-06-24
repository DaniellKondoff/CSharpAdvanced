using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            string text = "This is sample text. Boom!";
            string pattern = "is";

            //int startIndex = text.IndexOf(pattern);
            //string toBeReplaced = text.Substring(0, startIndex + pattern.Length);
            //string replaced = toBeReplaced.Replace(pattern, String.Empty);
            //text = text.Replace(toBeReplaced, replaced);

            var result=text.Remove(2);
            var result2 = text.Remove(2,pattern.Length);
            Console.WriteLine(result2);
        }
    }
}
