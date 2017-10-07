using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractMIddleElements
{
    static void Main()
    {
        var numbers =
            Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        var evenArrayLenght = new int[2];
        var oddArrayLenght = new int[3];

        if (numbers.Length == 1)
        {
            Console.WriteLine(string.Join("", numbers));
        }
        else if (numbers.Length % 2 == 0)
        {
            evenArrayLenght[0] = numbers[numbers.Length / 2 - 1];
            evenArrayLenght[1] = numbers[numbers.Length / 2];
            Console.WriteLine("{" + string.Join(", ", evenArrayLenght) + "}");
        }
        else
        {
            oddArrayLenght[0] = numbers[numbers.Length / 2 - 1];
            oddArrayLenght[1] = numbers[numbers.Length / 2];
            oddArrayLenght[2] = numbers[numbers.Length / 2 + 1];
            Console.WriteLine("{" + string.Join(", ",oddArrayLenght) + "}");
        }
    }

}

