using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WeatherForecast
{
    static void Main()
    {
        double currentNumber = double.Parse(Console.ReadLine());

        if (currentNumber % 1 != 0)
        {
            Console.WriteLine("Rainy");
        }
        else if (currentNumber >= sbyte.MinValue && currentNumber <= sbyte.MaxValue)
        {
            Console.WriteLine("Sunny");
        }
        else if (currentNumber >= int.MinValue && currentNumber <= int.MaxValue)
        {
            Console.WriteLine("Cloudy");
        }
        else if (currentNumber >= long.MinValue && currentNumber <= long.MaxValue)
        {
            Console.WriteLine("Windy");
        }
    }
}

