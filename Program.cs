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
            double distance = 0;
            double distance2 = 0;
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Inputs for Line "+i);
                ///to get the value of points from the user.
                Console.WriteLine("Enter the Value of x1 of first point : ");
                float x1 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Value of y1 of first point : ");
                float y1 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Value of x2 of Second point : ");
                float x2 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Value of y2 of second point : ");
                float y2 = Single.Parse(Console.ReadLine());
                if (i == 1)
                {
                    ///to calculate the length of a line 1.
                    distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                    ///Display the length of a line 1.
                    Console.WriteLine("The length of the line "+i+" is : " + distance);
                }
                if (i == 2)
                {
                    ///to calculate the length of a line 2
                    distance2 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                    ///Display the length of a line 2.
                    Console.WriteLine("The length of the line "+i+" is : " + distance2);
                }
            }
            ///To check the equality of the lines
            if (distance == distance2)
            {
                Console.WriteLine("The Lines are Equal");
            }
            else {
                Console.WriteLine("The lines are not Equal!");
            }
        }
    }
}
