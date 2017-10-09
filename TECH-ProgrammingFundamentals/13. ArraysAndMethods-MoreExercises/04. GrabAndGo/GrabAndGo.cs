using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GrabAndGo
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        int numberToFind = int.Parse(Console.ReadLine());

        bool isFoundOccurunce = false;
        long sum = 0;

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] == numberToFind)
            {
                var indexOfFoundedNumber = i;
                isFoundOccurunce = true;
                for (int j = 0; j < indexOfFoundedNumber; j++)
                {
                    sum += numbers[j];
                }
                break;
            }
        }

        if (isFoundOccurunce)
        {
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("No occurrences were found!");
        }
    }
}

