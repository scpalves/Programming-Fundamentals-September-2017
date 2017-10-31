namespace PF_Exam_04._09._2017
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Resurrection
    {
        public static void Main()
        {
            int numberOfPheonixes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPheonixes; i++)
            {
                long bodyTotalLenght = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long lenghtOfSingleWing = long.Parse(Console.ReadLine());

                decimal totalYears = CalculateTotalYears(bodyTotalLenght, totalWidth, lenghtOfSingleWing);

                Console.WriteLine(totalYears);
            }
        }

        public static decimal CalculateTotalYears(long bodyTotalLenght, decimal totalWidth, long lenghtOfSingleWing)
        {
            long totalLenght = (long)Math.Pow(bodyTotalLenght, 2);
            decimal totalYears = totalLenght * (totalWidth + 2 * lenghtOfSingleWing);

            return totalYears;
        }
    }
}
