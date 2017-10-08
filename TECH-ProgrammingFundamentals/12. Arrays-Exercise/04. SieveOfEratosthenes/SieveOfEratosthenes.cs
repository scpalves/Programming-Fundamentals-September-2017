using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        List<int> primeNumbers = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            primeNumbers.Add(i);
        }
        Console.WriteLine(string.Join(" ", FindPrimeNumbers(primeNumbers)));
    }

    public static List<int> FindPrimeNumbers(List<int> listToCheck)
    {
        int isPrime = 2;
        int position = 0;
        while (isPrime <= listToCheck.Count)
        {
            for (int i = 2; i <= listToCheck.Count; i++)
            {
                if (listToCheck.Contains(isPrime * i)) listToCheck.Remove(isPrime * i);
            }
            position++;
            isPrime = listToCheck[position];
        }
        return listToCheck;
    }
}
