using System;
using System.Text.RegularExpressions;


namespace _11.SemanticHTML
{
    class SemanticHTML
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string patternOpen = @"<(div)([^>]+)(?:id|class)\s*=\s*""(.*?)""(.*?)>";
            string patternClosed = @"<\/div>\s*<!--\s*(.*?)\s*-->";

            while (line != "END")
            {
                Match openMatch = Regex.Match(line, patternOpen);
                Match closeMatch = Regex.Match(line, patternClosed);
                if (openMatch.Success)
                {
                    line = Regex.Replace(line, patternOpen,@"$3 $2 $4").Trim();
                    line = "<" + Regex.Replace(line, @"\s+", " ") + ">";
                }
                else if (closeMatch.Success)
                {
                    line = "</" + closeMatch.Groups[1]+ ">";
                }
                Console.WriteLine(line);
                line = Console.ReadLine();
            }

        }
    }
}
