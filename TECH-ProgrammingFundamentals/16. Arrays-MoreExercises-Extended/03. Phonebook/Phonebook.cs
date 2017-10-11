namespace _03.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var names = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var command = Console.ReadLine();

            while (command != "done")
            {
                int indexOfNumber = Array.IndexOf(names, command);
                Console.WriteLine($"{command} -> {numbers[indexOfNumber]}");
                command = Console.ReadLine();
            }
        }
    }
}
