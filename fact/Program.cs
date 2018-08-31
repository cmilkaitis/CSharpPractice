using System;

namespace Factorialize
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number to factor: ");
            var num = Convert.ToInt32(Console.ReadLine());

            ulong result = Convert.ToUInt64(Factor.FactorNum(num));
            Console.WriteLine(result); 
        }
    }
}