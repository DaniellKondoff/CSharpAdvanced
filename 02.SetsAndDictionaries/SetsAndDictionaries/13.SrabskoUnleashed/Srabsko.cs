using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.SrabskoUnleashed
{
    class Srabsko
    {
        static void Main(string[] args)
        {
            var serbiaDict = new Dictionary<string ,Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                var venueTokens = Regex.Split(input," @");

                if (!(venueTokens.Length > 1))
                {
                    input = Console.ReadLine();
                    continue;
                }

                var singer = venueTokens[0];
                var venueAndTickets = venueTokens[1].Split();
                int ticketPrice = 0;
                int ticketCount = 0;
                try
                {
                    ticketPrice = int.Parse(venueAndTickets[venueAndTickets.Length - 2]);
                    ticketCount = int.Parse(venueAndTickets[venueAndTickets.Length - 1]);

                }
                catch (Exception)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var venue = new StringBuilder();
                for (int i = 0; i < venueAndTickets.Length-2; i++)
                {
                    venue.Append(venueAndTickets[i]);
                    venue.Append(" ");
                }

                
                if (serbiaDict.ContainsKey(venue.ToString()))
                {
                    if (serbiaDict[venue.ToString()].ContainsKey(singer))
                    {
                        serbiaDict[venue.ToString()][singer] += ticketCount * ticketPrice;
                    }
                    else
                    {
                        serbiaDict[venue.ToString()].Add(singer, (ticketCount * ticketPrice));
                    }
                }
                else
                {
                    serbiaDict[venue.ToString()] = new Dictionary<string, int>() { { singer, (ticketCount * ticketPrice) } };
                }
                input = Console.ReadLine();
            }

            foreach (var venue in serbiaDict)
            {
                Console.WriteLine(venue.Key);
                foreach (var singer in venue.Value.OrderByDescending(v=>v.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
