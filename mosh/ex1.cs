using System;

namespace Test
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Exercise 1
            //var input = Console.ReadLine();
            //var num = int.Parse(input);

            //if( num <= 10 && num >= 1)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invaild");
            //}

            //Exercise 2
            //var input1 = Console.ReadLine();
            //var num1 = int.Parse(input1);

            //var input2 = Console.ReadLine();
            //var num2 = int.Parse(input2);

            //Console.WriteLine( num1 + num2);
            Console.WriteLine("Enter in a speed limit: ");
            var input1 = Console.ReadLine();
            var speedLimit = int.Parse(input1);

            Console.WriteLine("Enter car speed: ");
            var input2 = Console.ReadLine();
            var carSpeed = int.Parse(input2);

            var demeritPoints = 0;

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Speed is legal.");
            }

            while (carSpeed > speedLimit)
            {
                demeritPoints++;
                carSpeed -= 5;
            }
            Console.WriteLine(string.Format("You have {0} demerits.", demeritPoints));

            if (demeritPoints > 12)
            {
                Console.WriteLine("Your license is suspended.");
            }
        }
    }
}
