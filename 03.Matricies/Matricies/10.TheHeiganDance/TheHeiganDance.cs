using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.TheHeiganDance
{
    class TheHeiganDance
    {
        private const int ChamberSize = 15;
        private const int CloudDamage = 3500;
        private const int ErruptionDamage = 6000;
        private const double PlaherHealth = 18500;
        private const double HeiganHealth = 3000000;
        static void Main(string[] args)
        {
            var playerPos = new int[] {ChamberSize/2, ChamberSize/2 };

            var heiganPoints = HeiganHealth;
            var playerPoints = PlaherHealth;
            bool isHeiganDead = false;
            bool isPlayerDead = false;
            bool hasCloud = false;
            var deathSpell = String.Empty;

            var damageToheigan = double.Parse(Console.ReadLine());

            while (true)
            {
                var spellTokens = Console.ReadLine().Split();
                var spell = spellTokens[0];
                var spellRow = int.Parse(spellTokens[1]);
                var spellCol = int.Parse(spellTokens[2]);


                heiganPoints -= damageToheigan;
                isHeiganDead = heiganPoints <= 0;
                isPlayerDead = playerPoints <= 0;

                if (hasCloud)
                {
                    playerPoints -= CloudDamage;
                    hasCloud = false;
                    isPlayerDead = playerPoints <= 0;
                }

                if (isHeiganDead || isPlayerDead)
                {
                    break;
                }

                if (IsPlayerInDamagedZone(playerPos, spellRow,spellCol))
                {
                    if (!PlayerTryEscape(playerPos,spellRow,spellCol))
                    {
                        switch (spell)
                        {
                            case "Cloud":
                                playerPoints -= CloudDamage;
                                hasCloud = true;
                                deathSpell = "Plague Cloud";
                                break;
                            case "Eruption":
                                playerPoints -= ErruptionDamage;
                                deathSpell = spell;
                                break;
                        }
                    }
                }
                isPlayerDead = playerPoints <= 0;
                if (isPlayerDead)
                {
                    break;
                }
               
            }

            PrintResult(playerPos, heiganPoints, playerPoints, deathSpell);
        }

        private static void PrintResult(int[] playerPos, double heiganPoints, double playerPoints, string deathSpell)
        {
            if (heiganPoints <=0)
            {
                Console.WriteLine("Heigan: Defeated!");
            }
            else
            {
                Console.WriteLine($"Heigan: {heiganPoints:f2}");
            }

            if (playerPoints <=0)
            {
                Console.WriteLine($"Player: Killed by {deathSpell}");
            }
            else
            {
                Console.WriteLine($"Player: {playerPoints}");
            }

            Console.WriteLine($"Final position: {playerPos[0]}, {playerPos[1]}");
        }

        private static bool PlayerTryEscape(int[] playerPos, int spellRow, int spellCol)
        {
            if (playerPos[0] - 1 >= 0 && playerPos[0] - 1 < spellRow-1)
            {
                playerPos[0]--;
                return true;
            }
            else if (playerPos[1] + 1 < ChamberSize && playerPos[1] + 1 > spellCol + 1)
            {
                playerPos[1]++;
                return true;
            }
            else if (playerPos[0] + 1 < ChamberSize && playerPos[0] + 1 > spellRow + 1)
            {
                playerPos[0]++;
                return true;
            }
            else if (playerPos[1] - 1 >=0 && playerPos[1]-1 < spellCol-1)
            {
                playerPos[1]--;
                return true;
            }

            return false;

        }

        private static bool IsPlayerInDamagedZone(int[] playerPos, int spellRow, int spellCol)
        {
            bool isHitRow = playerPos[0] >= spellRow - 1 && playerPos[0] <= spellRow + 1;
            bool isHitCol = playerPos[1] >= spellCol - 1 && playerPos[1] <= spellCol + 1;

            return isHitCol && isHitRow;
        }
    }
}
