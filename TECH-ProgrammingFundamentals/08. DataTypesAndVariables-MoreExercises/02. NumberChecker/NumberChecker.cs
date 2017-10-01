using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        decimal currentNumber = decimal.Parse(Console.ReadLine());

        if (currentNumber % 1 == 0)
        {
            Console.WriteLine("integer");
        }
        else
        {
            Console.WriteLine("floating-point");
        }
    }
}

