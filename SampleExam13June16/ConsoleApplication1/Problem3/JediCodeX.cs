using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem3
{
    class JediCodeX
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                text.Append(inputLine);
            }

            string namePattern = Console.ReadLine();
            string messagePattern = Console.ReadLine();

            int[] messagesIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Regex nameRegex = new Regex(Regex.Escape(namePattern) +@"([a-zA-Z]{" + namePattern.Length + @"})(?![a-zA-Z])");
            Regex messageRegex = new Regex(Regex.Escape(messagePattern) + @"([a-zA-Z0-9]{" + messagePattern.Length + @"})(?![a-zA-Z0-9])");

            List<string> jedis = new List<string>();
            List<string> messages = new List<string>();

            MatchCollection jediMatches = nameRegex.Matches(text.ToString());
            MatchCollection messagesMatches = messageRegex.Matches(text.ToString());

            foreach (Match jediMatch in jediMatches)
            {
                jedis.Add(jediMatch.Groups[1].Value);
            }


            foreach (Match messageMath in messagesMatches)
            {
                messages.Add(messageMath.Groups[1].Value);
            }

            int currentJediIndex = 0;
            List<string> output = new List<string>();

            for (int i = 0; i < messagesIndexes.Length; i++)
            {
                if (messagesIndexes[i] - 1 < messages.Count)
                {
                    output.Add($"{jedis[currentJediIndex]} - {messages[messagesIndexes[i]-1]}");
                    currentJediIndex++;
                }
                if (currentJediIndex >= jedis.Count)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join("\n",output));
        }
    }
}
