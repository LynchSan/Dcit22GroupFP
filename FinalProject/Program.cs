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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("WELCOME TO TESTING!");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Green;


            bool again = true;

            startOver:
            while (again)
            {

                Console.Write("Press (1) for Operations and press (2) for games: ");
                string t_input = Console.ReadLine();

                if (t_input.Length == 1 && t_input == "1")
                {
                    redo();
                    break;
                }
                else if (t_input.Length == 1 && t_input == "2")
                {
                    games();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input Please Type (1/2): ");
                }
            }

            while (true)
            {
                Console.Write("Do you wanna try again (Y/N): ");
                string verifyTry = Console.ReadLine().ToUpper();
                if (verifyTry == "Y" && verifyTry.Length == 1)
                {
                    goto startOver;
                }
                else if (verifyTry == "N" && verifyTry.Length == 1)
                {
                    again = false;
                    break;
                }
                else
                {
                    Console.Write("Invalid Input please type (Y/N): ");
                }
            }
                    


            Console.WriteLine("ThankYou!!!");
        }


        public static void redo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WELCOME PLEASE CHOOSE FROM 1-5");
            Console.WriteLine("(1)Arithmetic. (2)Convert_MM/CM/M. (3)ConditionalStatements.");
            Console.WriteLine("(4)OddOrEven. (5)Get Area & Circumference of Circle. (6)ExchangeValue");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter a Number(1-6): ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int value) && value >= 1 && value <= 6)
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
                        case 6:
                            Operations.exchange();
                            break;

                    }
                    break;
                }
                else
                {
                    Console.Write("Please Enter a valid number from 1-6: ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("DONE");


        }


        public static void games()
        {
            Console.Clear();
            Console.WriteLine("I need money!");
        }
    }
}
