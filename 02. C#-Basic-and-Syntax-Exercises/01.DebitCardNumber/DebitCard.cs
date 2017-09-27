using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Startup
{
    static void Main()
    {
        var firstCard = int.Parse(Console.ReadLine());
        var secondCard = int.Parse(Console.ReadLine());
        var thirdCard = int.Parse(Console.ReadLine());
        var fourtCard = int.Parse(Console.ReadLine());

        Console.WriteLine($"{firstCard:d4} {secondCard:d4} {thirdCard:d4} {fourtCard:d4}");
    }
}

