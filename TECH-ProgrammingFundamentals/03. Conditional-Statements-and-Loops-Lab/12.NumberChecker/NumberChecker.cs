﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberChecker
{
    static void Main()
    {
        
        try
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("It is a number.");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

