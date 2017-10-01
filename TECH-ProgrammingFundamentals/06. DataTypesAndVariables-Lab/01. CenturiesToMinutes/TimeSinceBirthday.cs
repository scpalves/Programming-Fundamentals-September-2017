using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TimeSinceBirthday
{
    static void Main()
    {
        var centuries = int.Parse(Console.ReadLine());

        long years = centuries * 100;
        long days = (long)(years * 365.2422);
        long hours = days * 24;
        long minutes = hours * 60;

        Console.WriteLine(centuries);
        Console.WriteLine($"{years} years {days} days {hours} hours {minutes} minutes");
    }
}

