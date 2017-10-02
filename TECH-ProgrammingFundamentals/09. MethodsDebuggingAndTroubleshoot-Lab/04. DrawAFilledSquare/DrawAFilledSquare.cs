using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DrawAFilledSquare
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        PrintTopAndBottomPart(number);

        for (int i = 0; i < number - 2; i++)
        {
            PrintMiddlePart(number);
        }

        PrintTopAndBottomPart(number);
    }

    static void PrintTopAndBottomPart(int number)
    {
        Console.WriteLine(new string('-', number * 2));
    }

    static void PrintMiddlePart(int number)
    {
        Console.Write("-");
        for (int i = 0; i < (number * 2 - 2) / 2; i++)
        {
            Console.Write("\\/");
        }
        Console.WriteLine("-");
    }
}

