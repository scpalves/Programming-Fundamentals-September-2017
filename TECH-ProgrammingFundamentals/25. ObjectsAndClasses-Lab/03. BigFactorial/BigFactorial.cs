namespace _03.BigFactorial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = number;

            for (int i = number - 1; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}
