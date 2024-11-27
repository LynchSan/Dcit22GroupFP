using System;

public class Operations
{

    //FOR ARITHMETIC
    public static void arithmetic()
    {
        Console.Clear();
        while (true)
        {
            Console.Clear();

            double firstNumber, secondNumber;

            Console.Write("\nEnter first number: ");
            if (!double.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; //For skipping the entire loop and ask the user again
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; //For skipping the entire loop and ask the user again
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

            break; // Break the loop
        }
    }

    //CONVERTING TO MM/CM/M
    public static void convertM()
    {
            Console.Clear();  // For smooth reset

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

    //CONDITONAL STATEMENTS
    public static void conditionalS()
    {
        Console.Clear(); // Reset the program to make my work more cleaner

        // Ask user to input a number
        Console.Write("\nEnter a number: ");
        string input = Console.ReadLine();


        // Attempt to parse the input of the user
        if (double.TryParse(input, out double number))
        {
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
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Yellow for error
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        // Reset color after the program
        Console.ResetColor();

    }
    //ODD OR EVEN
    public static void oddOrEven()
    {
        Console.Clear();
        Console.Write(" Please enter a number: ");

        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.Write("Invalid number please type a valid number!: ");
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

    //AREA AND CIRCUMFERENCE OF THE CIRCLE
    public static void circleAC()
    {
        Console.Clear();
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
}