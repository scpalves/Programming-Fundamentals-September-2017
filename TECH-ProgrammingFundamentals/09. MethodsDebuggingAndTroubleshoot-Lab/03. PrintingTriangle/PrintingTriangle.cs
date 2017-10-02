using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintingTriangle
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            PrintTriangleOfNumbers(1, i);
        }

        PrintTriangleOfNumbers(1, number);

        for (int i = number - 1; i >= 0; i--)
        {
            PrintTriangleOfNumbers(1, i);
        }
    }
    static void PrintTriangleOfNumbers(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

