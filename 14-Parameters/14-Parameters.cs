using System;
using System.Collections.Generic;
using System.Net;

/*
===============================================================================
PROJECT 14: PARAMETERS
===============================================================================
Objective:
- Understand and practice using parameters in methods.

Main Tasks:
1. Create a method called "SayHello" to print the message "Hello (name)".
2. Create a method called "SubtractNumbers" that takes two integers, subtracts one and prints the result.
3. Create a method called "Exit" that prints the message "Press any key to exit...", then waits for user input.

Example:
- Below is an example of a method with parameters:

    private static void AddNumbers(int num1, int num2)
    {
        int answer = num1 + num2;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine($"{num1} + {num2} equals {answer}");
    }

Questions:
1. What is a parameter?
2. When writing a method, what two things do you need to supply to create a parameter for it? 
   E.g. static void MyMethod(firstThing secondThing)
3. What is the difference between a parameter and an argument?

Extension Tasks:
1. Update "SayHello" to take two parameters, one for the first name and one for the last name.
2. Update the "Exit" method to take a ConsoleColor as a parameter, then use it to change the colour of the text.
3. Write your own methods that takes one or more parameters of various data types.

Additional Resources:
- Parameters in C#: https://www.tutorialspoint.com/csharp/csharp_value_parameters.htm
- Passing Parameters: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/passing-parameters
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_14_Parameters
    {
        static void Main(string[] args)
        {
            // Call the methods here, passing in the required arguments
            Console.WriteLine("number 1");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("number 2");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            sayhello(name);
            SubtractNumbers(num1, num2);
            exit();



   
            
        }

        // Write your methods including parameters here
        static void sayhello(string name)
        {
            Console.WriteLine($"hello{name}");
        }

        static void exit()
        { 
        Console.ReadKey();
        }
        static void SubtractNumbers(double num1, double num2)
        { 
        double answer = num1 - num2;
            Console.WriteLine($"{num1} minus {num2} = {answer}");
        }


    }
}

/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/