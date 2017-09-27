using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Startup
{
    static void Main()
    {
        var employeeName = Console.ReadLine();
        var employeeAge = Console.ReadLine();
        var employeeID = int.Parse(Console.ReadLine());
        var employeeSalary = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {employeeName}");
        Console.WriteLine($"Age: {employeeAge}");
        Console.WriteLine($"Employee ID: {employeeID:d8}");
        Console.WriteLine($"Salary: {employeeSalary:f2}");
    }
}

