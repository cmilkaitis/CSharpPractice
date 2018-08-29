using System;

namespace Primes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number to sum all of its primes: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SumPrimes.SumPrime(num));
        }
    }
}
