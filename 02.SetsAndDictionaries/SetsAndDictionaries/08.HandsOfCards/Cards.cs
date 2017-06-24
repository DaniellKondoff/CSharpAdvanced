using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HandsOfCards
{
    public class Cards
    {
        public static void Main(string[] args)
        {
            var players = new Dictionary<string, HashSet<string>>();
            var handout = Console.ReadLine();

            while (handout != "JOKER")
            {
                var handoutTokens = handout.Split(':');
                var playerName = handoutTokens[0];
                var cards = handoutTokens[1].Split(',').Select(c => c.Trim()).ToArray();

                if (players.ContainsKey(playerName))
                {
                    players[playerName].UnionWith(cards);
                }
                else
                {
                    players.Add(playerName, new HashSet<string>(cards));
                }

                handout = Console.ReadLine();
            }

            PrintPlayersAndScores(players);
        }

        internal static void PrintPlayersAndScores(Dictionary<string, HashSet<string>> players)
        {
            foreach (var player in players)
            {
                var score = CalculateScore(player.Value);
                Console.WriteLine($"{player.Key}: {score}");
            }
        }

        internal static int CalculateScore(HashSet<string> cards)
        {
            int score = 0;
            foreach (var card in cards)
            {
                var firstPower = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
                var secondPower = new List<string> { "C", "D", "H", "S" };

                var type = card.Substring(card.Length - 1);
                var power = card.Substring(0, card.Length - 1);

                int firstValue = firstPower.IndexOf(power) + 2;
                int secondValue = secondPower.IndexOf(type) + 1;
                score += firstValue * secondValue;
            }
            return score;
        }
    }
}
