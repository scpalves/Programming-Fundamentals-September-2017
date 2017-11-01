namespace _02.Entertrain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Entertrain
    {
        public static void Main()
        {
            int locomotivePower = int.Parse(Console.ReadLine());
            var wagons = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "All ofboard!")
                {
                    break;
                }

                wagons.Add(int.Parse(input));

                if (wagons.Sum() > locomotivePower)
                {
                    int average = (int)wagons.Average();
                    var closest = wagons.OrderBy(v => Math.Abs((long)v - average)).First();
                    wagons.Remove(closest);
                }
            }

            wagons.Reverse();
            wagons.Add(locomotivePower);

            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
