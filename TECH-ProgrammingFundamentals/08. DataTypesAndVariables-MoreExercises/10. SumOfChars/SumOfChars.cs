using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumOfChars
{
    static void Main()
    {
        int numberOfChars = int.Parse(Console.ReadLine());
        int sumOfChars = 0;

        for (int i = 0; i < numberOfChars; i++)
        {
            char currentChar = char.Parse(Console.ReadLine());
            sumOfChars += currentChar;
        }

        Console.WriteLine($"The sum equals: {sumOfChars}");
    }
}
