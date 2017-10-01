using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RestaurantDiscount
{
    static void Main()
    {
        int countOfGuests = int.Parse(Console.ReadLine());
        var package = Console.ReadLine();
        var packagePrice = 0.0;
        if (package == "Normal")
        {
            if (countOfGuests <= 50)
            {
                packagePrice = ((2500 + 500) * 0.95) / countOfGuests;
            }
            else if (countOfGuests <= 100)
            {
                packagePrice = ((5000 + 500) * 0.95) / countOfGuests;
            }
            else if (countOfGuests <= 120)
            {
                packagePrice = ((7500 + 500) * 0.95) / countOfGuests;
            }
        }
        else if (package == "Gold")
        {
            if (countOfGuests <= 50)
            {
                packagePrice = ((2500 + 750) * 0.90) / countOfGuests;
            }
            else if (countOfGuests <= 100)
            {
                packagePrice = ((5000 + 750) * 0.90) / countOfGuests;
            }
            else if (countOfGuests <= 120)
            {
                packagePrice = ((7500 + 750) * 0.90) / countOfGuests;
            }
        }
        else if (package == "Platinum")
        {
            if (countOfGuests <= 50)
            {
                packagePrice = ((2500 + 1000) * 0.85) / countOfGuests;
            }
            else if (countOfGuests <= 100)
            {
                packagePrice = 5000;
                packagePrice = ((5000 + 1000) * 0.85) / countOfGuests;
            }
            else if (countOfGuests <= 120)
            {
                packagePrice = 7500;
                packagePrice = ((7500 + 1000) * 0.85) / countOfGuests;
            }
        }
        if (countOfGuests <= 50)
        {
            Console.WriteLine("We can offer you the Small Hall");
            Console.WriteLine($"The price per person is {packagePrice:f2}$");
        }
        else if (countOfGuests <= 100)
        {
            Console.WriteLine("We can offer you the Terrace");
            Console.WriteLine($"The price per person is {packagePrice:f2}$");
        }
        else if (countOfGuests <= 120)
        {
            Console.WriteLine("We can offer you the Great Hall");
            Console.WriteLine($"The price per person is {packagePrice:f2}$");
        }
        else
        {
            Console.WriteLine("We do not have an appropriate hall.");
        }
    }
}

