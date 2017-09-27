using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Startup
{
    static void Main()
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNumber = int.Parse(Console.ReadLine());
        var sumOfTwoNumbers = firstNumber + secondNumber;
        Console.WriteLine($"{firstNumber} + {secondNumber} = {sumOfTwoNumbers}");
    }
}

