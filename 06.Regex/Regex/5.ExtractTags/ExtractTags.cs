﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.ExtractTags
{
    class ExtractTags
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"<.+?>";

            Regex regex = new Regex(pattern);


            while (text != "END")
            {
                MatchCollection matches = regex.Matches(text);

                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                }

                text = Console.ReadLine();
            }

        }
    }
}
