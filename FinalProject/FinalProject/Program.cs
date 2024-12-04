using System.Threading.Tasks;
using System;

namespace FinalProject
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("WELCOME TO TESTING!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            await MainMenu();
        }

        public static async Task MainMenu()
        {
            bool again = true;

            while (again)
            {
                Console.Write("Press (1) for Operations and press (2) for Games: ");
                string t_input = Console.ReadLine();

                if (t_input == "1")
                {
                    redo();
                }
                else if (t_input == "2")
                {
                    await games();
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please Type (1/2): ");
                    continue;
                }

                while (true)
                {
                    Console.Write("Do you want to try again (Y/N): ");
                    string verifyTry = Console.ReadLine().ToUpper();
                    if (verifyTry == "Y")
                    {
                        break;
                    }
                    else if (verifyTry == "N")
                    {
                        again = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Please type (Y/N): ");
                    }
                }
            }

            Console.WriteLine("Thank You!!!");
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


        public static async Task games()
        {
            Console.Clear();
            await snakeDesu.snakeGame();
        }
    }
}