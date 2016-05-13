/*
 * Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
Examples:

n	binary representation of n	p	bit @ p == 1
5	    00000000 00000101	    2	true
0	    00000000 00000000	    9	false
15	    00000000 00001111	    1	true
5343	00010100 11011111	    7	true
62241	11110011 00100001	    11	false
*/

using System;


class CheckBitGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please enter value for number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter value for bit index");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        bool result = ((n & mask) >> p) == 1;
        if ( result == true)
        {
            Console.WriteLine("The bit at index position {0} of number {1} is equal to 1 \"{2}\"", p, n, result);
        }
        else
        {
            Console.WriteLine("The bit at index position {0} of number {1} is not equal to 1 \"{2}\"", p, n, result);
        }
    }
}
