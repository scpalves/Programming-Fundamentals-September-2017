using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CharacterStats
{
    static void Main()
    {
        var playerName = Console.ReadLine();
        var currentHealth = int.Parse(Console.ReadLine());
        var maxHealth = int.Parse(Console.ReadLine());
        var currentEnergy = int.Parse(Console.ReadLine());
        var maxEnergy = int.Parse(Console.ReadLine());

        var numberOfDotsInHealth = maxHealth - currentHealth;
        var numberOfDotsInEnergy = maxEnergy - currentEnergy;
        Console.WriteLine($"Name: {playerName}");
        Console.WriteLine($"Health: |{new string('|', currentHealth)}{new string('.',numberOfDotsInHealth)}|");
        Console.WriteLine($"Energy: |{new string('|', currentEnergy)}{new string('.',numberOfDotsInEnergy)}|");

    }
}

