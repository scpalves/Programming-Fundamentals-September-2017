using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxMethod
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        var biggestNumber = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));
        var smallestNumber = Math.Min(firstNumber, Math.Max(secondNumber, thirdNumber));
        var result = GetMaxNumber(biggestNumber, smallestNumber);

        Console.WriteLine(result);
    }

    static int GetMaxNumber(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }

        return secondNumber;
    }
}

