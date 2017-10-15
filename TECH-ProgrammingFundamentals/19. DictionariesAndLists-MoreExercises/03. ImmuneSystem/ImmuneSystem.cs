namespace _03.ImmuneSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ImmuneSystem
    {
        public static void Main()
        {
            int health = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var viruses = new List<string>();
            int virusStrenght;
            int virusDamage;
            int currentHealth = health;
            int finalHealth = 0;
            double bonusHealth;

            while (input != "end")
            {
                finalHealth = 0;
                virusStrenght = CalculateVirusStrenght(input);
                virusDamage = virusStrenght * input.Length;

                if (viruses.Contains(input))
                {
                    virusDamage /= 3;
                }
                Console.WriteLine($"Virus {input}: {virusStrenght} => {virusDamage} seconds");

                if (currentHealth > virusDamage)
                {
                    currentHealth -= virusDamage;
                    if (currentHealth > 0)
                    {
                        int minutes = (int)virusDamage / 60;
                        int seconds = (int)virusDamage % 60;
                        Console.WriteLine($"{input} defeated in {minutes}m {seconds}s.");
                        Console.WriteLine($"Remaining health: {currentHealth}");
                        bonusHealth = Math.Floor(currentHealth * 1.20);
                        currentHealth = (int)bonusHealth;

                        if (currentHealth > health)
                        {
                            currentHealth = health;
                        }
                        finalHealth = currentHealth;
                    }
                    else
                    {
                        Console.WriteLine("Immune System Defeated.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                viruses.Add(input);
                input = Console.ReadLine();
            }
            Console.WriteLine($"Final Health: {finalHealth}");
        }

        public static int CalculateVirusStrenght(string word)
        {
            int sum = 0;
            for (int i = 0; i < word.Length; i++)
            {
                sum += word[i];
            }
            return sum /= 3;
        }
    }
}
