using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FinalProject
{
    internal class loginUI
    {
        public static void userInterFace()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Dictionary<string, string> groupM = new Dictionary<string, string>
            {
                { "gm1", "Aldritch" },
                { "gm2", "Beyonce" },
                { "gm3", "Danniel" },
                { "gm4", "Harvey" },
                { "gm5", "Vincent" },
                { "gm6", "Johnn" },
                { "gm7", "Kenneth" },
                { "gm8", "Kylle" },
                { "gm9", "Marc" },
                { "gm10", "Lynch" },
                { "gm11", "Test" }

            };


            //"Aldritch", "Beyonce", "Danniel", "Harvey", "Vincent", "Johnn", "Kenneth", "Kylle", "Marc", "Lynch", "Test"
            Console.Write("Enter username: ");
            string inputUN = Console.ReadLine();

            string key = null;


            foreach (var userN in groupM)
            {
                if (userN.Value == inputUN)
                {
                    key = userN.Key;
                    break;
                }
            }


            while (key == null)
            {
                Console.WriteLine();
                Console.WriteLine("Username not found, try again.");
                Console.Write("Enter username: ");
                inputUN = Console.ReadLine();

                foreach (var userN in groupM)
                {
                    if (userN.Value == inputUN)
                    {
                        key = userN.Key;
                        break;
                    }
                }
            }



            Console.Write($"Enter password for {inputUN}: ");
            string pass = Console.ReadLine();

            while (!key.Equals(pass))
            {
                Console.WriteLine();
                Console.WriteLine("Incorrect password!");
                Console.Write($"Enter password for {inputUN}: ");
                pass = Console.ReadLine();
            }
            Console.Clear();
            string msg = "WELCOME TO GROUP 3 FINAL PROJECT!!";
            foreach (var letters in msg)
            {
                Thread.Sleep(50);
                Console.Write(letters);
            }

            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
