using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RefactorSpecialNumbers
{
    static void Main()
    {
        int digit = int.Parse(Console.ReadLine());
        int sum = 0;
        int cycleCopier = 0;
        bool dividedOrNot = false;

        for (int i = 1; i <= digit; i++)
        {
            cycleCopier = i;
            while (cycleCopier > 0)
            {
                sum += cycleCopier % 10;
                cycleCopier /= 10;
            }
            dividedOrNot = sum == 5 || sum == 7 || sum == 11;
            Console.WriteLine($"{i} -> {dividedOrNot}");

            sum = 0;
        }
    }
}

