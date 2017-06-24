using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ParseTags
{
    class Parsetags
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            int startIndex = text.IndexOf(openTag);
            

            while (startIndex != -1)
            {
                int endIndex = text.IndexOf(closeTag);

                if (endIndex == -1)
                {
                    break;
                }

                var toBeReplaced = text.Substring(startIndex, endIndex + closeTag.Length - startIndex);
                var replaced = toBeReplaced.Replace(openTag, String.Empty).Replace(closeTag, String.Empty).ToUpper();

                text = text.Replace(toBeReplaced, replaced);
                startIndex = text.IndexOf(openTag);
            }
            Console.WriteLine(text);
        }
    }
}
