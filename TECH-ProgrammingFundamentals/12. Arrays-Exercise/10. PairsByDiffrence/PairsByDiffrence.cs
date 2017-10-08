using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PairsByDiffrence
{
    static void Main()
    {
        var numbers =
            Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        int diffrenceBetweenNumbers = int.Parse(Console.ReadLine());
        int diffrencesCounter = 0;

        for (int a = 0; a <= numbers.Length - 1; a++)
        {
            for (int b = a + 1; b <= numbers.Length - 1; b++)
            {
                if (Math.Abs(numbers[a] - numbers[b]) == diffrenceBetweenNumbers)
                {
                    diffrencesCounter++;
                }
            }
        }

        Console.WriteLine(diffrencesCounter);
    }
}

