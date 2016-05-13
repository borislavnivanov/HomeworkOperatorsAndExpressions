/*
  Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
  (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
Examples:

n	Prime?
1	false
2	true
3	true
4	false
9	false
97	true
51	false
-3	false
0	false
 */

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        bool IsPrime = true;
        int number;
        Console.WriteLine("Please enter a number:");
        bool Isint = int.TryParse(Console.ReadLine(), out number);
        if (Isint)
        {
            if (number <= 1)
            {
                IsPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        IsPrime = false;
                    }
                }
            }
            Console.WriteLine("The number {0} is a prime number is {1}", number, IsPrime);
        }
        else
        {
            Console.WriteLine("Invalid entry!");
        }
    }
}
