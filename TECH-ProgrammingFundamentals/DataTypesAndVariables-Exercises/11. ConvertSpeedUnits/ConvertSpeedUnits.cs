using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConvertSpeedUnits
{
    static void Main()
    {
        int distanceInMeters = int.Parse(Console.ReadLine());
        float hours = float.Parse(Console.ReadLine());
        float minutes = float.Parse(Console.ReadLine());
        float seconds = float.Parse(Console.ReadLine());

        float time = hours + minutes / 60f + seconds / 3600.0f;
        float speedInKm = (distanceInMeters / 1000f) / time;
        float speedInMeters = speedInKm / 3.6f;
        float speedInMiles = (distanceInMeters / 1609.0f) / time;

        Console.WriteLine(speedInMeters);
        Console.WriteLine(speedInKm);
        Console.WriteLine(speedInMiles);
    }
}

