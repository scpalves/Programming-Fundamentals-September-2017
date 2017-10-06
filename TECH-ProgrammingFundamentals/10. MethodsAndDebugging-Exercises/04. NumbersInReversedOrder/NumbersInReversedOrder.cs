using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1_HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            RotateNumbers(Math.Abs(n));
        }

        private static void RotateNumbers(decimal n)
        {

            Console.WriteLine(n.ToString().Reverse().ToArray());
        }
    }
}