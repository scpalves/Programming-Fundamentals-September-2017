using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Greeting
{
    static void Main(string[] args)
    {
        var firstName = Console.ReadLine();
        var lastName = Console.ReadLine();
        var years = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hello, {firstName} {lastName}. You are {years} years old");
    }
}

