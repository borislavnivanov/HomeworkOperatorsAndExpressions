/*
 * Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle 
 * R(top=1, left=-1, width=6, height=2).
Examples:

x	y	inside K & outside of R
1	2	yes
2.5	2	no
0	1	no
2.5	1	no
2	0	no
4	0	no
2.5	1.5	no
2	1.5	yes
1	2.5	yes
-100	-100	no
 */

using System;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        double X, Y, R;
        R = 1.5;

        Console.WriteLine("Please enter value for point X:");
        bool pointX = double.TryParse(Console.ReadLine(), out X);

        Console.WriteLine("Please enter value for point Y:");
        bool pointY = double.TryParse(Console.ReadLine(), out Y);

        if (pointX && pointY)
        {
            bool IsInCircle = ((X - 1) * (X - 1)) + ((X - 1) * (X - 1)) <= (R * R);
            bool IsOutOfrectangle = X > 1 || X < 6 && Y > -1 || Y < 2;

            if (X == 0 || Y == 0)
            {
                Console.WriteLine("The points are not in the circle and/or are in the rectangle \"NO\"");
            }
           else if (IsInCircle == true && IsOutOfrectangle == true)
            {
                Console.WriteLine("The points are in the circle and out of the rectangle \"YES\"");
            }
            else
            {
                Console.WriteLine("The points are not in the circle and/or are in the rectangle \"NO\"");
            }
        }
        else
        {
            Console.WriteLine("Please enter valid value!");
        }
    }
}