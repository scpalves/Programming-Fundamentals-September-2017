using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BPMCounter
{
    static void Main()
    {
        var beatsPerMinute = int.Parse(Console.ReadLine());
        var numberOfBeats = int.Parse(Console.ReadLine());

        var bars = Math.Round(numberOfBeats / 4.0, 1);
        var seconds = numberOfBeats * 60.0 / beatsPerMinute;
        var minutes = (int)seconds / 60;
        seconds -= minutes * 60;

        Console.WriteLine($"{bars} bars - {minutes}m {Math.Floor(seconds)}s");
    }
}

