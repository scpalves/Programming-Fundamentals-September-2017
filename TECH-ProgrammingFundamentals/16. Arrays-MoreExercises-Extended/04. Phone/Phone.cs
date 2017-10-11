namespace _04.Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phone
    {
        public static string[] phones;
        public static string[] names;
        public static void Main()
        {
            phones = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            names = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var tokens = Console.ReadLine();

            while (tokens != "done")
            {
                var cmd = tokens.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = cmd[0];
                string argument = cmd[1];
                string name;
                string telephoneNumber;
                string output;

                if (IsNumber(argument))
                {
                    name = GetEntry(argument);
                    telephoneNumber = argument;
                    output = name;
                }
                else
                {
                    name = argument;
                    telephoneNumber = GetEntry(argument);
                    output = telephoneNumber;
                }

                int digitSum = GetDigitSum(telephoneNumber);
                if (command == "call")
                {
                    Console.WriteLine($"calling {output}...");
                    if (digitSum % 2 == 0)
                    {
                        int minutes = digitSum / 60;
                        int seconds = digitSum % 60;
                        Console.WriteLine($"call ended. duration: {minutes.ToString().PadLeft(2, '0')}:{seconds.ToString().PadLeft(2, '0')}");
                    }
                    else
                    {
                        Console.WriteLine("no answer");
                    }
                }
                else
                {
                    Console.WriteLine($"sending sms to {output}...");
                    if (digitSum % 2 == 0)
                    {
                        Console.WriteLine("meet me there");
                    }
                    else
                    {
                        Console.WriteLine("busy");
                    }
                }

                tokens = Console.ReadLine();
            }

        }

        public static int GetDigitSum(string telephoneNumber)
        {
            int sum = 0;
            for (int i = 0; i < telephoneNumber.Length; i++)
            {
                if (IsDigit(telephoneNumber[i]))
                {
                    sum += telephoneNumber[i] - '0';
                }
            }
            return sum;
        }

        public static string GetEntry(string input)
        {
            for (int i = 0; i < phones.Length; i++)
            {
                if (names[i] == input)
                {
                    return phones[i];
                }
                else if (phones[i] == input)
                {
                    return names[i];
                }
            }

            return string.Empty;
        }

        public static bool IsNumber(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsDigit(char symbol)
        {
            return (symbol >= '1' && symbol <= '9');
        }
    }
}
