using System;
namespace Primes
{
    public static class SumPrimes
    {
        public static int SumPrime(int num)
        {
            int sum = 0;

            for (int i = 2; i <= num; i++)
            {
                if(IsPrime.CheckPrime(i))
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
