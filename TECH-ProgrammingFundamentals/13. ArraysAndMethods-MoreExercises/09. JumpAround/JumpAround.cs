using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JumpAround
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int sum = 0;
        int index = 0;

        while (true)
        {
            var saveIndex = index;
            sum += numbers[saveIndex];
            index += numbers[saveIndex];
            if (index > numbers.Length - 1)
            {
                index = saveIndex - numbers[saveIndex];
                if (index < 0)
                {
                    break;
                }
            }
        }

        Console.WriteLine(sum);
    }
}

