namespace PF_Exam_09._07._2017
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PokeMon
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int countOfPokedTargets = 0;
            int halfValueOfN = n / 2;

            while (n >= m)
            {
                n -= m;
                if (n == halfValueOfN && y != 0)
                {
                    n /= y;
                }
                countOfPokedTargets++;
            }

            Console.WriteLine(n);
            Console.WriteLine(countOfPokedTargets);
        }
    }
}
