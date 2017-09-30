using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintPartOfASCIITable
{
    static void Main()
    {
        int startOfCharSequence = int.Parse(Console.ReadLine());
        int endOfCharSequence = int.Parse(Console.ReadLine());

        for (int i = startOfCharSequence; i <= endOfCharSequence; i++)
        {
            Console.Write((char) i + " ");
        }
        Console.WriteLine();
    }
}

