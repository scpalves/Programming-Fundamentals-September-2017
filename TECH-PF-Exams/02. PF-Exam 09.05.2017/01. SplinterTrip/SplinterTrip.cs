namespace PF_Exam_09._05._2017
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplinterTrip
    {
        public static void Main()
        {
            double miles = double.Parse(Console.ReadLine());
            double tankCapacity = double.Parse(Console.ReadLine());
            double milesThroughWinds = double.Parse(Console.ReadLine());

            double totalFuelUsed, remainingFuel;

            CalculatingNeededFuel(miles, tankCapacity, milesThroughWinds, out totalFuelUsed, out remainingFuel);
            PrintingFinalResult(tankCapacity, totalFuelUsed, remainingFuel);
        }

        private static void PrintingFinalResult(double tankCapacity, double totalFuelUsed, double remainingFuel)
        {
            string output = (totalFuelUsed <= tankCapacity)
                   ? $"Enough with {remainingFuel:f2}L to spare!"
                   : $"We need {Math.Abs(remainingFuel):f2}L more fuel.";

            Console.WriteLine($"Fuel needed: {totalFuelUsed:f2}L");
            Console.WriteLine(output);
        }

        private static void CalculatingNeededFuel(double miles, double tankCapacity, double milesThroughWinds, out double totalFuelUsed, out double remainingFuel)
        {
            double nonHeavyMiles = (miles - milesThroughWinds) * 25;
            double heavyWindMles = milesThroughWinds * (25 * 1.5);
            double totalFuelUsedNeeded = nonHeavyMiles + heavyWindMles;
            totalFuelUsed = (totalFuelUsedNeeded * 1.05);
            remainingFuel = tankCapacity - totalFuelUsed;
        }
    }
}
