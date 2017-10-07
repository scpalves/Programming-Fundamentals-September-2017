using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var day = int.Parse(Console.ReadLine());
        var daysOfWeek = new String[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

        if (day >= 1 && day <= 7)
        {
            Console.WriteLine(daysOfWeek[day - 1]);
        }
        else
        {
            Console.WriteLine("Invalid Day!");
        }
    }
}

