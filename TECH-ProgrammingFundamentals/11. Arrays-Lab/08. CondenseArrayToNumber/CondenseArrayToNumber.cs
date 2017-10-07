using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CondenseArrayToNumber
{
    static void Main()
    {
        var numbers = 
            Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        

        while (numbers.Count != 1)
        {
            var result = new List<int>();
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                result.Add(numbers[i] + numbers[i + 1]);
            }
            numbers = result;
        }

        Console.WriteLine(string.Join("", numbers));
    }
}

