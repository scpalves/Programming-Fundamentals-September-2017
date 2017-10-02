using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MathPower
{
    static void Main()
    {
        var number = double.Parse(Console.ReadLine());
        var pow = double.Parse(Console.ReadLine());
        var powerOfNumber = MathPow(number, pow);

        Console.WriteLine(powerOfNumber);
    }

    static double MathPow(double number, double pow)
    {
        var powerOfNumber = Math.Pow(number, pow);
        return powerOfNumber;
    }
}

