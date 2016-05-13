/*
 Write an expression that checks for given integer if its third digit from right-to-left is 7.
Examples:

n	Third digit 7?
5	    false
701    	true
9703	true
877	    false
777877	false
9999799	true
*/

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int userInput;
        bool check = false;
        Console.WriteLine("Please enter a number:");
        bool validate = int.TryParse(Console.ReadLine(), out userInput);
        if (validate)
        {
            if (userInput % 1000 > 699 && userInput % 1000 < 800)
            {
                check = true;
            }

            Console.WriteLine("The statement: 3rd number from right to left is 7 is: " + check);
        }
        else
        {
            Console.WriteLine("Please enter valid number");
        }
    }

}
