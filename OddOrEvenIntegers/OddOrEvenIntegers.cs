/*
Write an expression that checks if given integer is odd or even.
Examples:

n	Odd?
3	true
2	false
-2	false
-1	true
0	false
*/

using System;


class OddOrEvenIntegers
{
    static void Main()
    {
        int number;
        string inputNumber = null;
        while (inputNumber != "exit")
        {
            Console.WriteLine("\nEnter a number to assess:");
            inputNumber = Console.ReadLine();

            int.TryParse(inputNumber, out number);

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even (divisible by 2 without remainder).");
            }
            else
            {
                Console.WriteLine("The number is odd (liaves remainder when devided by 2).");
            }
        }
        return;
    }
}