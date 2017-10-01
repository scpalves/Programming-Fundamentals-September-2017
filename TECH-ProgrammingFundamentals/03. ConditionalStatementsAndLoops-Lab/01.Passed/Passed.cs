using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Passed
{
    static void Main()
    {
        var grade = double.Parse(Console.ReadLine());
        if (grade >= 3.00)
        {
            Console.WriteLine("Passed!");
        }
    }
}

