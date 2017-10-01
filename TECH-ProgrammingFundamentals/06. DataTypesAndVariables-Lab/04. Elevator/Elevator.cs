using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Elevator
{
    static void Main()
    {
        var numberOfPeople = int.Parse(Console.ReadLine());
        var capacity = int.Parse(Console.ReadLine());

        var totalCourses = (int)Math.Ceiling((double)numberOfPeople / capacity);
        
        Console.WriteLine(totalCourses);
        
    }
}

