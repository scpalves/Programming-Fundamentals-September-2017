using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DivisibleBy3
{
    static void Main()
    {
        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

