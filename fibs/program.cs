using System;

namespace SumFibs
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter a number to get the sum of Fibs: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Fib.ToFib(num));
        }
    }
}
