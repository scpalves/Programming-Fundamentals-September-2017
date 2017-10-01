using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HouseBuilder
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        decimal totalPrice = 0m;

        byte byteNumber = (byte)Math.Min(firstNumber, secondNumber);
        totalPrice += byteNumber * 4m;
        int intNumber = Math.Max(firstNumber, secondNumber);
        totalPrice += intNumber * 10m;

        Console.WriteLine(totalPrice);
    }
}

