namespace Arrays_Lab_Extended
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SumArrayElements
    {
        public static void Main()
        {
            int countOfInputNumbers = int.Parse(Console.ReadLine());
            var numbers = new int[countOfInputNumbers];

            for (int i = 0; i < countOfInputNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            var sumOfNumbers = numbers.Sum();
            Console.WriteLine(sumOfNumbers);
        }
    }
}
