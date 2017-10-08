using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var numbers =
            Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        bool isFound = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            var leftSum = numbers.Take(i).ToArray();
            var rightSum = numbers.Skip(i + 1).ToArray();
            if (leftSum.Sum() == rightSum.Sum())
            {
                Console.WriteLine(i);
                isFound = true;
                break;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("no");
        }
    }
}
