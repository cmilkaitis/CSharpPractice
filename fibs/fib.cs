using System;
namespace SumFibs
{
    public static class Fib
    {
        public static int ToFib(int num)
        {
            int prev = 0;
            int curr = 1;
            int result = 0;

            while (curr <= num)
            {
                if (curr % 2 != 0)
                {
                    result += curr;
                }

                curr += prev;
                prev = curr - prev;
            }

            return result;
        }
    
    }
}

