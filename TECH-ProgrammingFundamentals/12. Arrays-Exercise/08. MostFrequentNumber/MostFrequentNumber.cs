using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSequenceOfIncreasingElements
{
    static void Main()
    {
        var numbers =
            Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        var mostOccurences = new Dictionary<int, int>();

        foreach (var number in numbers)
        {
            if (mostOccurences.ContainsKey(number))
            {
                mostOccurences[number]++;
            }
            else
            {
                mostOccurences.Add(number, 1);
            }
        }

        foreach (var mostOccurence in mostOccurences.OrderByDescending(x => x.Value))
        {
            Console.WriteLine(mostOccurence.Key);
            break;
        }
    }
}

