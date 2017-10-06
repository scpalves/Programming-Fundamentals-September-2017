using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HelloName
{
    static void Main()
    {
        var name = Console.ReadLine();
        HelloNameUser(name);
    }

    static void HelloNameUser(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

