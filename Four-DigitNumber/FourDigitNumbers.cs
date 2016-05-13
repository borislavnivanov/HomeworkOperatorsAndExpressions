/*
 * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.

Examples:

n	sum of digits	reversed	last digit in front | second and third digits exchanged
2011	4	        1102	        1201	                    2101
3333	12	        3333	        3333	                    3333
9876	30      	6789	        6987	                    9786
 */
using System;

class FourDigitNumbers
{
    static void Main()
    {
        int[] numbers = new int[3] { 2011, 3333, 9876 };
        for (int i = 0; i < numbers.Length; i++)
        {
            int a = (numbers[i] / 1000);
            int b = ((numbers[i] / 100) % 10);
            int c = ((numbers[i] / 10) % 10);
            int d = (numbers[i] % 10);
            int sum = (a + b + c + d);
            string number = Convert.ToString(numbers[i]);


            Console.WriteLine("Number: | Sum: | Reversed | Last dig in front | second and third digits exchanged\n {0}   |   {1} |  {5}{4}{3}{2}    |  {5}{2}{3}{4}             |   {2}{4}{3}{5}\n\n", number, sum, a, b, c, d);

        }
    }
}

