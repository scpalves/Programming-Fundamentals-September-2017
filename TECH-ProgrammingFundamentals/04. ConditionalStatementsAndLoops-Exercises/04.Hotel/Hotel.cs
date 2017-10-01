using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hotel
{
    static void Main()
    {
        string month = Console.ReadLine();
        int countNight = int.Parse(Console.ReadLine());

        double pricesStudio = 0.0;
        double pricesDouble = 0.0;
        double pricesSuite = 0.0;

        switch (month)
        {
            case "May":
            case "October":
                pricesStudio = 50;
                pricesDouble = 65;
                pricesSuite = 75;
                break;
            case "June":
            case "September":
                pricesStudio = 60;
                pricesDouble = 72;
                pricesSuite = 82;
                break;
            case "July":
            case "August":
            case "December":
                pricesStudio = 68;
                pricesDouble = 77;
                pricesSuite = 89;
                break;
        }
        if (month == "May" || month == "October" && countNight > 7)
        {
            pricesStudio *= 0.95;
        }
        else if (month == "June" || month == "September" && countNight > 14)
        {
            pricesDouble *= 0.9;
        }
        else if ((month == "July" || month == "August" || month == "December") && countNight > 14)
        {
            pricesSuite *= 0.85;
        }
        double endPriceDoule = pricesDouble * countNight;
        double endPriceStudio = pricesStudio * countNight;
        double endPriceSuite = pricesSuite * countNight;

        if ((month == "September" || month == "October") && countNight > 7)
        {
            endPriceStudio -= pricesStudio;
        }
        Console.WriteLine("Studio: {0:f2} lv.", endPriceStudio);
        Console.WriteLine("Double: {0:f2} lv.", endPriceDoule);
        Console.WriteLine("Suite: {0:f2} lv.", endPriceSuite);
    }
}

