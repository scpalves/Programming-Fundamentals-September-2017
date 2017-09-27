using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddNumber
{
    static void Main()
    {
        var oddNumber = int.Parse(Console.ReadLine());
        while (oddNumber % 2 == 0)
        {
            oddNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write an odd number.");
        }
        var absValueOfOddNumber = Math.Abs(oddNumber);
        Console.WriteLine($"The number is: {absValueOfOddNumber}");
    }
}
