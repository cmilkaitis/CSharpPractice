using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x;
            // int y;

            // x = 7;
            // y = x + 3;

            // Console.WriteLine(y);

            int[] nums = new int[5];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i*2;
            }

             for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            string testString = "This is a test of array methods and such.";

            char[] charArray = testString.ToCharArray();
            Array.Reverse(charArray);

            foreach (char letter in charArray)
            {
                Console.Write(letter);
            }

        }
    }
}
