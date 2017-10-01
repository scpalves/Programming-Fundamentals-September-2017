using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NeighbourWars
{
    static void Main()
    {
        var goshoHealth = 100;
        var peshoHealth = 100;
        var turns = 0;
        var roundCounter = 0;

        var peshoDamage = int.Parse(Console.ReadLine());
        var goshoDamage = int.Parse(Console.ReadLine());

        while (goshoHealth > 0 || peshoHealth > 0)
        {
            turns++;
            if (turns % 2 != 0)
            {
                roundCounter++;
                goshoHealth -= peshoDamage;
                if (goshoHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {roundCounter}th round.");
                    break;
                }
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
            }
            else
            {
                roundCounter++;
                peshoHealth -= goshoDamage;
                if (peshoHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {roundCounter}th round.");
                    break;
                }
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
            }
            if (turns % 3 == 0)
            {
                goshoHealth += 10;
                peshoHealth += 10;
            }
        }
    }
}

