using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TripleSum
{
    static void Main()
    {
        var numbers =
            Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var isFound = false;
        for (int a = 0; a <= numbers.Length - 1; a++)
        {
            for (int b = a + 1; b <= numbers.Length - 1; b++)
            {
                for (int c = 0; c <= numbers.Length - 1; c++)
                {
                    if (numbers[a] + numbers[b] == numbers[c])
                    {
                        isFound = true;
                        Console.WriteLine($"{numbers[a]} + {numbers[b]} == {numbers[c]}");
                        break;
                    }
                }
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}

