using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CubicRube
{
    class CubeRube
    {
        static void Main(string[] args)
        {
            int dimnsionsSIze = int.Parse(Console.ReadLine());
            var sumOfParts = 0L;
            int counter = 0;
            string inputLine;

            while ((inputLine=Console.ReadLine()) != "Analyze")
            {
                var tokens = inputLine.Split(' ').Select(int.Parse).ToArray();
                if (tokens.Take(3).Any(pt => pt < 0 || pt >= dimnsionsSIze))
                {
                    continue;
                }
                if (tokens[3] != 0)
                {
                    sumOfParts += tokens[3];
                    counter++;
                }


                
            }

            Console.WriteLine(sumOfParts);
            Console.WriteLine($"{Math.Pow(dimnsionsSIze,3) - counter}");
        }
    }
}
