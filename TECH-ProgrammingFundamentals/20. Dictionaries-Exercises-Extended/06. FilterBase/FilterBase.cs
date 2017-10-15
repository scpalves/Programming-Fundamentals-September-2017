namespace _06.FilterBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FilterBase
    {
        

        public static void Main()
        {
            var  nameAndPositions = new Dictionary<string, string>();
            var  nameAndAges = new Dictionary<string, int>();
            var  nameAndSalarys = new Dictionary<string, decimal>();

            string input = Console.ReadLine();
            while (input != "filter base")
            {
                var inputTokens = input
                    .Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];
                var info = inputTokens[1];
                string position = string.Empty;
                int age = 0;
                decimal salary = 0m;

                if (IsLetter(info))
                {
                    nameAndPositions.Add(name, info);
                }
                else if (int.TryParse(info, out age))
                {
                    nameAndAges.Add(name, age);
                }
                else
                {
                    salary = decimal.Parse(info);
                    nameAndSalarys.Add(name, salary);
                }
                input = Console.ReadLine();
            }

            var personalInfo = Console.ReadLine();
            if (personalInfo == "Position")
            {
                foreach (var nameAndPosition in nameAndPositions)
                {
                    string name = nameAndPosition.Key;
                    string position = nameAndPosition.Value;
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Position: {position}");
                    Console.WriteLine("====================");
                }
            }
            else if (personalInfo == "Age")
            {
                foreach (var nameAndAge in nameAndAges)
                {
                    string name = nameAndAge.Key;
                    int age = nameAndAge.Value;
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine("====================");
                }
            }
            else
            {
                foreach (var nameAndSalary in nameAndSalarys)
                {
                    string name = nameAndSalary.Key;
                    decimal salary = nameAndSalary.Value;
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Salary: {salary:f2}");
                    Console.WriteLine("====================");
                }
            }
        }

        public static bool IsLetter(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
