using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ComparingFloats
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        double eps = 0.000001;
        double result = Math.Abs(firstNumber - secondNumber);

        if (result >= eps)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("True");
        }
        
    }
}

