using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TESTING");

            Console.WriteLine("WELCOME PLEASE CHOOSE FROM 1-5");
            Console.WriteLine("(1)Arithmetic. (2)Convert_MM/CM/M. (3)ConditionalStatements. (4)OddOrEven. (5)Get Area and Circumference of Circle");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter a Number(1-5): ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int value) && value >= 1 && value <= 5)
                {

                    switch (value)
                    {
                        case 1:
                            Operations.arithmetic();
                            break;
                        case 2:
                            Operations.convertM();
                            break;
                        case 3:
                            Operations.conditionalS();
                            break;
                        case 4:
                            Operations.oddOrEven();
                            break;
                        case 5:
                            Operations.circleAC();
                            break;

                    }
                    break;
                }
                else
                {
                    Console.Write("Please Enter a valid number from 1-5: ");
                }
            }

            Console.WriteLine("DONE");
        }
    }
}
