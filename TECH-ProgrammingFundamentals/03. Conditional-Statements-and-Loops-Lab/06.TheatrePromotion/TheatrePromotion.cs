using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TheatrePromotion
{
    static void Main()
    {
        var typeOfDay = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());
        var ticketPrice = 0.0;

        switch (typeOfDay)
        {
            case "Weekday":
                if (age >= 0 && age <= 18)
                {
                    ticketPrice = 12;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 18;
                }
                else if (age > 64 && age <= 122)
                {
                    ticketPrice = 12;
                }
                break;
            case "Weekend":
                if (age >= 0 && age <= 18)
                {
                    ticketPrice = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    ticketPrice = 15;
                }
                break;
            case "Holiday":
                if (age >= 0 && age <= 18)
                {
                    ticketPrice = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    ticketPrice = 10;
                }
                break;
            
        }
        if (age >= 0 && age <= 122)
        {
            Console.WriteLine($"{ticketPrice}$");
        }
        else
        {
            Console.WriteLine("Error!");
        }
        
    }
}
