namespace PF_Exam_30._04._2017
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Wormtest
    {
        public static void Main()
        {
            long lenght = long.Parse(Console.ReadLine()) * 100;
            double width = double.Parse(Console.ReadLine());

            double remainder = lenght % width;

            if (remainder == 0 || lenght == 0 || width == 0)
            {
                Console.WriteLine($"{(lenght * width):f2}");
            }
            else
            {
                double precentages = lenght / width * 100;
                Console.WriteLine($"{precentages:f2}%");
            }
        }
    }
}
