using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CenturiesToNanoseconds
{
    static void Main()
    {
        byte centuries = byte.Parse(Console.ReadLine());
        int years = centuries * 100;
        int days = (int)(years * 365.2422);
        int hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        long milliSeconds = seconds * 1000;
        decimal microSeconds = milliSeconds * 1000m;
        decimal nanoSeconds = microSeconds * 1000m;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = " +
            $"{minutes} minutes = {seconds} seconds = {milliSeconds} milliseconds = {microSeconds} microseconds = " +
            $"{nanoSeconds} nanoseconds");

    }
}

