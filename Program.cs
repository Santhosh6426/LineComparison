/*
*  C# CODING STANDARDS - LINE SPACE
* NOTE - A SINGLE BLANK LINE SEPARATES THE TWO BLOCKS i.e. USING STATEMENTS, CLASS DECLARATION, etc
*/

/******************************************************************************
 *  Compilation:  C:\Users\Santhu\source\repos\LineComparison\bin\Debug\netcoreapp3.1\LineComparison.exe
 *  Execution:    LineComparison.exe
 *  
 *  Purpose: Determines whether or not n is prime.
 *
 *  @author  Santhosh V
 *  @version 2019
 *  @since   2019
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program.");
            ///to get the value of points from the user.
            Console.WriteLine("Enter the Value of x1 of first point : ");
            float x1 =Single.Parse( Console.ReadLine());
            Console.WriteLine("Enter the Value of y1 of first point : ");
            float y1 =Single.Parse( Console.ReadLine());
            Console.WriteLine("Enter the Value of x2 of Second point : ");
            float x2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value of y2 of second point : ");
            float y2 = Single.Parse(Console.ReadLine());
            ///to calculate the length of a line
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            ///Display the length of a line.
            Console.WriteLine("The length of the line is : "+distance);
        }
    }
}
