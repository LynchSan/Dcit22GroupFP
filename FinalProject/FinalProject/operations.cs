using System;
using System.Net.NetworkInformation;

public class Operations
{



    //FOR ARITHMETIC /1/



    public static void arithmetic()
    {
        Console.Clear();

        double firstNumber, secondNumber;
        Console.WriteLine("Outputs the Arithmetic numbers");

        while (true)
            {
                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out firstNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number: ");
                }
                else
                {
                    break;
                }
            }
        while (true)
            {
                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out secondNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                else
                {
                    break;
                }
            }

        // For calculation of each operator
        double sum = firstNumber + secondNumber;
        double diff = firstNumber - secondNumber;
        double product = firstNumber * secondNumber;
        double quo = secondNumber != 0 ? firstNumber / secondNumber : double.NaN;
        double mod = secondNumber != 0 ? firstNumber % secondNumber : double.NaN;

        // Display result
        Console.WriteLine("\nResults:");
        Console.WriteLine($"Addition: {sum}");
        Console.WriteLine($"Subtraction: {diff}");
        Console.WriteLine($"Multiplication: {product}");
        Console.WriteLine($"Division: {(double.IsNaN(quo) ? "Undefined (division by zero)" : quo.ToString())}");
        Console.WriteLine($"Remainder: {(double.IsNaN(mod) ? "Undefined (division by zero)" : mod.ToString())}");

    }




    //CONVERTING TO MM/CM/M /2/



     public static void convertM()
    {
        Console.Clear();  // For smooth reset
        Console.WriteLine("Converts MM/CM/M");
        double millimeter;

        while (true)
        {
            // Ask user to input a value
            Console.Write("\nEnter the value in millimeters: ");


            if (double.TryParse(Console.ReadLine(), out millimeter))  // Input validation 
            {
                // Perform conversions
                double centimeter = millimeter / 10.0;
                double meter = millimeter / 1000.0;

                // Display the results with formatted output
                Console.WriteLine("\n\nConversion Results:");
                Console.WriteLine($"Millimeters: {millimeter}");
                Console.WriteLine($"Centimeters: {centimeter}");
                Console.WriteLine($"Meters     : {meter}");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number."); // Simplified error handling
            }
        }
    }



    //CONDITONAL STATEMENTS /3/



    public static void conditionalS()
    {
        Console.Clear(); // Reset the program to make my work more cleaner

        double number;
        // Ask user to input a number
        Console.WriteLine("Checks if number is positive or negative.");
        Console.Write("\nEnter a number: ");


        // Attempt to parse the input of the user
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Please Enter a valid number!: ");
        }

        string result;
        Console.ForegroundColor = ConsoleColor.White;  // Reset color for result message

        if (number > 0)
        {
            result = "positive";
            Console.ForegroundColor = ConsoleColor.Green; // Green for positive
            Console.WriteLine("The number " + number + " is " + result + ".");
            Console.ForegroundColor = ConsoleColor.Green;

        }
        else if (number < 0)
        {
            result = "negative";
            Console.ForegroundColor = ConsoleColor.Red; // Red for negative
            Console.WriteLine("The number " + number + " is " + result + ".");
            Console.ForegroundColor = ConsoleColor.Red;

        }
        else
        {
            result = "zero";
            Console.ForegroundColor = ConsoleColor.Gray; // Cyan for zero
            Console.WriteLine("The number " + number + " is " + result + ".");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        // Reset color after the program
        Console.ResetColor();

    }



    //ODD OR EVEN /4/




    public static void oddOrEven()
    {
        Console.Clear();
        Console.WriteLine("Checks if number is Odd or Even\n");
        Console.Write("Enter a number: ");

        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.Write("Please type a valid number!: ");
            }
            else
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is an even number");
                    break;

                }
                else
                {
                    Console.WriteLine($"{num} is an odd number");
                    break;
                }
            }
        }
    }

    //AREA AND CIRCUMFERENCE OF THE CIRCLE /5/
    public static void circleAC()
    {
        Console.Clear();
        Console.WriteLine("Get the Area and Circumference of Circle");
        Console.Write("Enter a Radius: ");

        // Declare num outside of the while loop to make it accessible in the whole method
        double num;

        // Ensure that the input is a valid number
        while (!double.TryParse(Console.ReadLine(), out num))
        {
            Console.Write("Please Enter a valid number: ");
        }

        // Calculation
        double area = Math.PI * num * num; // Area = π * r^2
        double circumference = 2 * Math.PI * num; // Circumference = 2 * π * r

        // Display the result
        Console.WriteLine($"The Area is {area}");
        Console.WriteLine($"The Circumference is {circumference}");
    }

    //PROGRAM EXCHANGING THE VALUES OF THE 2INPUTS /6/




    public static void exchange()
    {
        Console.Clear();
        // Declare the variables outside the loop
        Console.WriteLine("Swap the two Input Numbers\n");
        double num1;
        double num2;

        // Input validation for the first number
        Console.Write("Input the First Number: ");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Please Enter a valid number: ");
        }

        // Input validation for the second number
        Console.Write("Input the Second Number: ");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Please Enter a valid number: ");
        }

        
        double temp1 = num1;
        num1 = num2;
        num2 = temp1;

        Console.Write("\nAfter swapping: \n");
        Console.WriteLine($"First number: {num1}");
        Console.WriteLine($"Second number: {num2}");


    }
}