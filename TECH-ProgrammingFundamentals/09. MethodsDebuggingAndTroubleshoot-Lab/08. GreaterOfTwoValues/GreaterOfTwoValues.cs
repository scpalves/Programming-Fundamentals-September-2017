using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GreaterOfTwoValues
{
    static void Main()
    {
        var dataType = Console.ReadLine();

        if (dataType == "int")
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var bigger = GetMax(first, second);
            Console.WriteLine(bigger);
        }
        else if (dataType == "char")
        {
            var first = char.Parse(Console.ReadLine());
            var second = char.Parse(Console.ReadLine());
            var bigger = GetMax(first, second);
            Console.WriteLine(bigger);
        }
        else
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            var bigger = GetMax(first, second);
            Console.WriteLine(bigger);
        }
    }

    static int GetMax(int first, int second)
    {
        return Math.Max(first, second);
    }

    static char GetMax(char first, char second)
    {
        if (first > second)
        {
            return first;
        }
        return second;
    }

    static string GetMax(string first, string second)
    {
        if (first.CompareTo(second) > 0)
        {
            return first;
        }
        return second;
    }
}

