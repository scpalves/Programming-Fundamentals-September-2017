namespace NestedDictionaries_Exercises_Extended
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Wardrobe
    {
        public static void Main()
        {
            int numberOfCloths = int.Parse(Console.ReadLine());
            var wardrobeData = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfCloths; i++)
            {
                var currentCloth = Console.ReadLine()
                    .Split(new string[]{" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string color = currentCloth[0];
                var cloths = currentCloth[1].Split(',').ToList();

                if (!wardrobeData.ContainsKey(color))
                {
                    wardrobeData.Add(color, new Dictionary<string, int>());
                }
                foreach (var cloth in cloths)
                {
                    if (!wardrobeData[color].ContainsKey(cloth))
                    {
                        wardrobeData[color].Add(cloth, 0);
                    }
                    wardrobeData[color][cloth]++;
                }
            }

            var clothForSearch = Console.ReadLine()
                .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string colorToSearch = clothForSearch[0];
            string clothToSearch = clothForSearch[1];

            foreach (var wardrobe in wardrobeData)
            {
                string color = wardrobe.Key;
                var clothsAndQuantity = wardrobe.Value;
                Console.WriteLine($"{color} clothes:");
                foreach (var clothAndQuantity in clothsAndQuantity)
                {
                    string cloth = clothAndQuantity.Key;
                    int quantity = clothAndQuantity.Value;
                    if (color == colorToSearch && cloth == clothToSearch)
                    {
                        Console.WriteLine($"* {cloth} - {quantity} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {quantity}");
                    }
                }
            }
        }
    }
}
