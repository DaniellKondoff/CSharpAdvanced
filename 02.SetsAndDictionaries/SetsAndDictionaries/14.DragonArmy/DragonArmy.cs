namespace _14.DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class DragonArmy
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var allDragons = new Dictionary<string, SortedDictionary<string, int[]>>();

            const int DefaultDemage= 45;
            const int DefaultHealth = 250;
            const int DefaultArmor = 10;


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);
                string type = input[0];
                string name = input[1];
                var damage = input[2].Equals("null") ? DefaultDemage : int.Parse(input[2]);
                var health = input[3].Equals("null") ? DefaultHealth : int.Parse(input[3]);
                var armor = input[4].Equals("null") ? DefaultArmor : int.Parse(input[4]);

                if (allDragons.ContainsKey(type))
                {
                        allDragons[type][name] = new int[] { damage, health, armor };
                }
                else
                {
                    allDragons[type] = new SortedDictionary<string, int[]>() { {name,new int[] {damage,health,armor} } };
                }
            }

            foreach (var dragonType in allDragons)
            {
                var dragonTypeInfo = new StringBuilder();
                double avrDemage = 0;
                double avrHealth = 0;
                double avrArmor = 0;

                foreach (var dragon in dragonType.Value)
                {
                    dragonTypeInfo.Append($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}\r\n");
                    avrDemage += dragon.Value[0];
                    avrHealth += dragon.Value[1];
                    avrArmor += dragon.Value[2];
                }

                avrDemage /= dragonType.Value.Count;
                avrArmor /= dragonType.Value.Count;
                avrHealth /= dragonType.Value.Count;

                Console.WriteLine($"{dragonType.Key}::({avrDemage:f2}/{avrHealth:f2}/{avrArmor:f2})");
                Console.Write(dragonTypeInfo.ToString());
            }
        }
    }
}
