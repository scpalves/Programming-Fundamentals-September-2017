using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WaterOverflow
{
    static void Main()
    {
        int puttingWaterInTank = int.Parse(Console.ReadLine());
        int litersInTank = 0;
        int currentLiters = 0;

        for (int i = 0; i < puttingWaterInTank; i++)
        {
            int inputLiters = int.Parse(Console.ReadLine());
            int tankTotalCapacity = 255;
            currentLiters += inputLiters;

            if (currentLiters > tankTotalCapacity)
            {
                Console.WriteLine("Insufficient capacity!");
                currentLiters = litersInTank;
            }
            else
            {
                litersInTank += inputLiters;
            }
        }

        Console.WriteLine(litersInTank);
    }
}

