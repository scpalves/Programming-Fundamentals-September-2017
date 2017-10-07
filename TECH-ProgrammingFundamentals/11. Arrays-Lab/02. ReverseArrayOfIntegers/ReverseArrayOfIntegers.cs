using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseArrayOfIntegers
{
    static void Main()
    {
        var countOfNumbers = int.Parse(Console.ReadLine());
        var numbers = new int[countOfNumbers];

        for (int i = 0; i < countOfNumbers; i++)
        {
            var currentNumber = int.Parse(Console.ReadLine());
            numbers[i] = currentNumber;
        }

        Array.Reverse(numbers);
        Console.WriteLine(string.Join(" ",numbers));
    }
}

