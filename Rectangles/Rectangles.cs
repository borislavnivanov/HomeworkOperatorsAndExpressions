/*
 Write an expression that calculates rectangle’s perimeter and area by given width and height.
Examples:

width	height	perimeter	area
3	    4	       14	    12
2.5    	3	       11	    7.5
5	    5	       20	    25     (actually thats a square)
*/

using System;

class Rectangles
{
    static void Main()
    {
        double height;
        double width;

        Console.WriteLine("What is the rectangle's width?");
        double.TryParse(Console.ReadLine(), out width);
        Console.WriteLine("What is the rectangle's height?");
        double.TryParse(Console.ReadLine(), out height);

        double perimeter = (2 * (height + width));
        double area = (height * width);

        Console.WriteLine("The rectangle's perimeter is {0}, and the area is {1}.",perimeter, area);
    }
}
