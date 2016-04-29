// Author: Jonathan Spalding
// Assignment: Lab 09
// Instructor Roger deBry
// Clas: CS 1400
// Date Written: 2/4/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using static System.Console;
namespace Lab09
{
    class Program
    {
        // The static void Main Method
        // Purpose: take the radius of one circle, and find the unused space between four of these circles in a square. (In other words, get Farmer John the area of the grey area between his crops)
        // Parameters: None? I deleted everything in the parentheses below.
        // Returns: none
        static void Main()
        {
            // declare the variables and constants that will be used in the program.
            const double SQUARED = 2; //because I can't use magic numbers...
            const double TWO = 2; //again because I can't use magic numbers. It seems counterproductive using this many constants.
            // ask the user to input the radius of one of his fields and put that in a variable.
            WriteLine("Please type the radius of one of your fields and press Enter.");
            double radius = double.Parse(Console.ReadLine());
            // Multiply this radius squared (math.pow()) by pi (math.PI()) and put it in its own variable as the area.
            double cropArea =  Math.PI * Math.Pow(radius, SQUARED);
            // Multiply the radius by two, then squared to find the area of the square between the four vertices, then assign it to a variable as the area for the squre.
            double squareArea = Math.Pow((radius * TWO), SQUARED);
            // Subract the circle's area from the square's area, and the difference is the area of the greyed out area in the diagram mentioned in the assignment.
            double greyArea = squareArea - cropArea;
            // Output in a writeline the area so the user can know the answer.
            WriteLine($"The Area Between your Four Crops is: {greyArea:f2}");
            ReadKey(true);
        }
    }
}