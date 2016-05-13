/*
 Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.
Examples:

n	            p	q	k	binary representation of n	                 binary result	                        result
1140867093	    3	24	3	01000100 00000000 01000000 00010101	         01000010 00000000 01000000 00100101	1107312677
4294901775	    24	3	3	11111111 11111111 00000000 00001111	         11111001 11111111 00000000 00111111	4194238527
2369124121	    2	22	10	10001101 00110101 11110111 00011001	         01110001 10110101 11111000 11010001	1907751121
987654321	    2	8	11	00111010 11011110 01101000 10110001	                        -	                    overlapping
123456789	    26	0	7	00000111 01011011 11001101 00010101	                        -	                    out of range
33333333333	    -1	0	33	00000111 11000010 11010010 01001101 01010101	            -	                    out of range
 */

using System;


class BitExchangeAdvanced
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Please enter value for n:");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for p:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for q:");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for k:");
            int k = int.Parse(Console.ReadLine());

            if ((Math.Max(p, q) + k - 1) > 31)
            {
                Console.WriteLine("Out of range");
            }
            else if ((Math.Min(p, q) + k - 1) >= Math.Max(p, q))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                for (int i = p; i <= ((p + k) - 1); i++)
                {
                    uint mask = 1;

                    uint bitP = ((mask << i) & n) >> i;
                    uint bitQ = ((mask << q) & n) >> q;

                    n = n & ~(mask << i);
                    n = n & ~(mask << q);
                    n = n | (bitP << q);
                    n = n | (bitQ << i);

                    q++;

                }

                Console.WriteLine(n);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nOut of range integer\n\n" + ex);
        }
    }
}