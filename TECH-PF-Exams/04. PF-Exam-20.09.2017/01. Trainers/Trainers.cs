namespace PF_Exam_20._09._2017
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Trainers
    {
        public static void Main()
        {
            int practicipants = int.Parse(Console.ReadLine());
            decimal[] array = new decimal[3];

            for (int i = 0; i < practicipants; i++)
            {
                long miles = long.Parse(Console.ReadLine()) * 1600;
                decimal cargo = decimal.Parse(Console.ReadLine()) * 1000;
                string teamName = Console.ReadLine();

                decimal profit = (1.5m * cargo) - (0.7m * miles * 2.5m);

                CalculatingProfit(array, teamName, profit);
            }

            CalculatingWinnerAndPrintIt(array);
        }

        private static void CalculatingWinnerAndPrintIt(decimal[] array)
        {
            decimal winner = array.OrderByDescending(x => x).First();

            if (winner == array[0])
            {
                Console.WriteLine($"The Theoretical Trainers win with ${winner:f3}.");
            }
            else if (winner == array[1])
            {
                Console.WriteLine($"The Practical Trainers win with ${winner:f3}.");
            }
            else if (winner == array[2])
            {
                Console.WriteLine($"The Technical Trainers win with ${winner:f3}.");
            }
        }

        private static void CalculatingProfit(decimal[] array, string teamName, decimal profit)
        {
            switch (teamName)
            {
                case "Theoretical":
                    array[0] += profit;
                    break;
                case "Practical":
                    array[1] += profit;
                    break;
                case "Technical":
                    array[2] += profit;
                    break;
            }
        }
    }
}
