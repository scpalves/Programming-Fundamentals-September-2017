using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountTheIntegers
{
    static void Main()
    {
        var counter = 0;

        try
        {
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                counter++;
            }
        }
        catch (Exception)
        {
            Console.WriteLine(counter);
        }
    }
}

