namespace _12.DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static Dictionary<string, Dictionary<string, List<int>>> dragonsData =
            new Dictionary<string, Dictionary<string, List<int>>>();
        public static void Main()
        {
            int numberOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfDragons; i++)
            {
                var currentDragon = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string type = currentDragon[0];
                string name = currentDragon[1];
                var damageHealthArmor = currentDragon
                    .Skip(2)
                    .ToList();
                AddToDragonData(type, name, damageHealthArmor);
            }
            PrintDragonData();
        }

        public static void AddToDragonData(string type, string name, List<string> damageHealthArmor)
        {
            if (!dragonsData.ContainsKey(type))
            {
                dragonsData.Add(type, new Dictionary<string, List<int>>());
            }
            if (!dragonsData[type].ContainsKey(name))
            {
                dragonsData[type].Add(name, new List<int>());
            }

            int damage;
            int health;
            int armor;

            damage = damageHealthArmor[0] != "null" ? int.Parse(damageHealthArmor[0]) : 45;
            health = damageHealthArmor[1] != "null" ? int.Parse(damageHealthArmor[1]) : 250;
            armor = damageHealthArmor[2] != "null" ? int.Parse(damageHealthArmor[2]) : 10;

            dragonsData[type][name] = new List<int>(){damage, health, armor };
        }


        public static void PrintDragonData()
        {
            foreach (var dragonData in dragonsData)
            {
                string type = dragonData.Key;
                Console.WriteLine($"{type}::({dragonData.Value.Select(x => x.Value[0]).Average():f2}" +
                                  $"/{dragonData.Value.Select(x => x.Value[1]).Average():f2}" +
                                  $"/{dragonData.Value.Select(x => x.Value[2]).Average():f2})");

                var dragonsAndPower = dragonData.Value;

                foreach (var dragonAndPower in dragonsAndPower.OrderBy(x => x.Key))
                {
                    string name = dragonAndPower.Key;
                    var power = dragonAndPower.Value;
                    int damage = power[0];
                    int health = power[1];
                    int armor = power[2];

                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}