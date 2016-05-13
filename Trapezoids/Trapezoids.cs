/*Write an expression that calculates trapezoid's area by given sides a and b and height h.
Examples:
    
a	    b   	h	    area
5   	7	    12	    72
2   	1	    33	    49.5
8.5	    4.3	    2.7	    17.28
100 	200	    300	    45000
0.222	0.333	0.555	0.1540125
 */

using System;

class Trapezoids
{
    static void Main()
    {
        double a, b, h;
        Console.WriteLine("Please enter value for base A of the trapezoid:");
        bool isNumberA = double.TryParse(Console.ReadLine(), out a);
        Console.WriteLine("Please enter value for base B of the trapezoid:");
        bool isNumberB = double.TryParse(Console.ReadLine(), out b);
        Console.WriteLine("Please enter value for high of the trapezoid:");
        bool isNumberH = double.TryParse(Console.ReadLine(), out h);
        
        if (isNumberA && isNumberB && isNumberH)
        {
            double area = ((a + b) / 2) * h;
            Console.WriteLine("\nThe area of the trapezoid is {0}.", area);
        }
        else
        {
            Console.WriteLine("Please enter valid values");
        }
    }
}