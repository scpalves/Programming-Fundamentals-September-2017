using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var oddNumber = int.Parse(Console.ReadLine());

        var borderSpace = 0;
        var middleSpace = oddNumber - 2;

        for (int i = 0; i < oddNumber / 2; i++)
        {
            Console.WriteLine(new string(' ', borderSpace) + "x" + new string(' ', middleSpace) + "x");
            borderSpace++;
            middleSpace -= 2;
        }
        Console.WriteLine(new string(' ', borderSpace) + "x");

        for (int i = 0; i < oddNumber / 2; i++)
        {
            borderSpace--;
            middleSpace += 2;
            Console.WriteLine(new string(' ', borderSpace) + "x" + new string(' ', middleSpace) + "x");
        }
    }
}

