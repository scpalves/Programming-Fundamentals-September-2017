using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DiffrentNumbers
{
    static void Main()
    {
        var start = int.Parse(Console.ReadLine());
        var end = int.Parse(Console.ReadLine());

        bool isFound = false;

        for (int n1 = start; n1 < end; n1++)
        {
            for (int n2 = start; n2 < end; n2++)
            {
                for (int n3 = start; n3 < end; n3++)
                {
                    for (int n4 = start; n4 < end; n4++)
                    {
                        for (int n5 = start; n5 <= end; n5++)
                        {
                            if (start <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= end)
                            {
                                Console.WriteLine($"{n1} {n2} {n3} {n4} {n5}");
                                isFound = true;
                            }
                        }
                    }
                }
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}

