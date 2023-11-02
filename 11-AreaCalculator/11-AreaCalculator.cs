using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Services;

/*
===============================================================================
PROJECT 11: AREA CALCULATOR
===============================================================================
Objective:
- Enhance understanding of selection, user input, and maths operations by calculating areas of different shapes based on user choices.

Main Tasks:
1. Create a menu that asks the user to choose between calculating the area of a rectangle or triangle.
2. Prompt the user for their choice and store it in a variable.
3. Using selection, complete the program to calculate the area of either rectangles or triangles
4. Handle invalid menu choices with a warning message.
5. Create a "Press any key to exit..." message at the end of the program.

Questions:
1. What is the difference between Console.Write() and Console.WriteLine()?
2. How is the area of each shape calculated? What mathematical operations are used?

Extension Tasks:
1. Extend the program to calculate the area of other shapes and add them to the menu. E.g. Circle, trapezium.

Example:
- Below is an example of the program's output:

    Choose an Option:
    1. Area of Circle
    2. Area of Rectangle
    3. Area of Triangle

    2

    Enter Width: 3
    Enter Height: 4

    The area of the rectangle is 12

    "Press any key to exit...

Additional Resources:
- Mathematical Functions in C#: https://www.ictdemy.com/csharp/basics/mathematical-functions-in-csharp-net-math-library
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_11_AreaCalculator
    {
        static void Main(string[] args)
        {

        

           
            // Your code goes below here
            Console.WriteLine("choose an option");
            Console.WriteLine("1. area of a circle");
            Console.WriteLine("2. area of a rectangle");
            Console.WriteLine("3. area of a triangle");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter Radius: ");
                double Radius = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * Math.Pow(Radius, 2);
                Console.WriteLine($"the area of this circle is {area}");

            }
            else if (choice == "2")
            {
                Console.WriteLine("enter Width");
                double Width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter Height");
                double Height = Convert.ToDouble(Console.ReadLine());
                double area = Width * Height;
                Console.WriteLine($"the are of this rectangle is {area}") ;


            }
              else if (choice == "3")

            {
                Console.WriteLine("enter Base");
                double Base = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter Height");
                double Height = Convert.ToDouble (Console.ReadLine());
                double area = .5 * Base * Height;
                Console.WriteLine($"the area of this triangle is {area}");

            }
            Console.ReadLine();
        }
    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/