/*
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
Examples:

weight	weight on the Moon
86  	14.624
74.6	12.682
53.7	9.129
*/

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double earthMass;
        double moonMass;
        double moonGravity = 0.17;
        string userInput = "0";
        while (userInput != "exit")
        {
            Console.WriteLine("\nPlease enter mass as measured on Earth:");
            userInput = Console.ReadLine();
            earthMass = double.Parse(userInput);
            moonMass = (earthMass * moonGravity);
            Console.WriteLine("The mass on Earth of {0}, ends up to to the mass of {1} on the moon.", earthMass, moonMass);
         }
        return;
    }
}
