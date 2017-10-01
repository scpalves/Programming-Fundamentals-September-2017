using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BackIn30Minutes
{
    static void Main()
    {
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());

        minutes += 30;
        while (minutes >= 60)
        {
            minutes -= 60;
            hours++;
        }

        while (hours >= 24)
        {
            hours -= 24;
        }

        Console.WriteLine($"{hours}:{minutes:D2}");
    }
}

