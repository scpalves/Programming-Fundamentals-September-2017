using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GameOfNumbers
{
    static void Main()
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());
        var magicalNumber = int.Parse(Console.ReadLine());

        var isCombinatoinFound = false;
        var counter = 0;

        for (int a = secondNumber; a >= firstNumber; a--)
        {
            for (int b = firstNumber; b <= secondNumber; b++)
            {
                counter++;
                if (a + b == magicalNumber)
                {
                    isCombinatoinFound = true;
                    Console.WriteLine($"Number found! {a} + {b} = {magicalNumber}");
                    return;

                }
            }
        }

        if (!isCombinatoinFound)
        {
            Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
        }
    }
}

