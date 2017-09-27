using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriangleOfNumbers
{
    static void Main()
    {
        var currentNumber = int.Parse(Console.ReadLine());
        for (int row = 1; row <= currentNumber; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(row + " ");
            }
            Console.WriteLine();
        }
    }
}

