using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SentenceTheThief
{
    static void Main()
    {
        string numeralType = Console.ReadLine();
        int countOfIds = int.Parse(Console.ReadLine());

        long parsed = 0;
        long years = 0;
        long saveId = long.MinValue;
        for (int i = 0; i < countOfIds; i++)
        {
            parsed = long.Parse(Console.ReadLine());

            if (numeralType == "sbyte")
            {
                if (parsed >= sbyte.MinValue && parsed <= sbyte.MaxValue)
                {
                    if (saveId < parsed)
                    {
                        saveId = parsed;
                    }
                }
            }
            else if (numeralType == "int")
            {
                if (parsed >= int.MinValue && parsed <= int.MaxValue)
                {
                    if (saveId < parsed)
                    {
                        saveId = parsed;
                    }
                }
            }
            else if (numeralType == "long")
            {
                if (parsed >= long.MinValue && parsed <= long.MaxValue)
                {
                    if (saveId < parsed)
                    {
                        saveId = parsed;
                    }
                }
            }
        }

        if (saveId >= sbyte.MinValue && saveId <= sbyte.MaxValue)
        {
            years = Math.Abs(saveId / saveId);
            if (years > 1)
            {
                Console.WriteLine($"Prisoner with id {saveId} is sentenced to {years} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {saveId} is sentenced to {years} year");
            }
        }
        else
        {
            if (saveId < 0)
            {
                years = (long)Math.Ceiling(Math.Abs((double)saveId / sbyte.MinValue));
            }
            else
            {
                years = (long)Math.Ceiling((double)saveId / sbyte.MaxValue);
            }

            if (years > 1)
            {
                Console.WriteLine($"Prisoner with id {saveId} is sentenced to {years} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {saveId} is sentenced to {years} year");
            }
        }
    }
}

