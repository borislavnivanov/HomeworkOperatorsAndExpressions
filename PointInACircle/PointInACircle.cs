/*
 * Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
Examples:

x	    y	    inside
0	    1	    true
-2	    0	    true
-1	    2	    false
1.5	    -1	    true
-1.5	-1.5	false
100	    -30	    false
0	    0	    true
0.2	    -0.8	true
0.9	    -1.93	false
1	    1.655	true
*/

using System;

class PointInACircle
{
    static void Main()
    {
        bool check = false;
        double x, y, r;
        r = 2;
        Console.WriteLine("Enter value for X:");
        bool xCheck = double.TryParse(Console.ReadLine(), out x);
        Console.WriteLine("Enter value for Y':");
        bool yCheck = double.TryParse(Console.ReadLine(), out y);
        if (xCheck && yCheck)
        {
            if (((x*x) + (y*y)) <= (r * r))
            {
                check = true;
            }
            Console.WriteLine("The statment that the coordinates of X-{0} and Y-{1} are contained within the circle is {2}.", x , y , check );
        }
        else
        {
            Console.WriteLine("Please enter valid values.");
        }

    }
}

