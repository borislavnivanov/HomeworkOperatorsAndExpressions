/*
Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
Examples:

n	Divided by 7 and 5?
3	false
0	true
5	false
7	false
35	true
140	true
 */


using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        bool result = false;
        int number;
        Console.WriteLine("Please enter a number to check:");
        bool userInput = int.TryParse(Console.ReadLine(), out number);
        if (number % 7 == 0 && number % 5 == 0)
        {
            result = true;
        }
        if (result == true)
        {
            Console.WriteLine("The number you have entered can be divided by 5 and 7 simontaniously (True)");
        }
        else
        {
            Console.WriteLine("The number you have entered can't be divided by 5 and 7 simontaniously (False)");
        }
        
    }
}
