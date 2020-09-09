/*
 * Grace Reed
 * ITSE 1430 
 * Lab 1 - Budget
 */
using System;

namespace Budget
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                char choice = DisplayMenu();
                if (choice == 'Q')
                    return;
                else if (choice == 'A')
                    AddInfo();
            };

            string accountNickname = "";
            string accountNumber = "";
            decimal startingBalance;
        }

        static char DisplayMenu ()
        {
            do
            {
                Console.WriteLine("Budget Account Information");
                Console.WriteLine("---------------------");

                Console.WriteLine("A)dd Account Information");
                Console.WriteLine("Q)uit");

                string value = Console.ReadLine();

                if (value == "Q")
                    return 'Q';
                else if (value == "A")
                    return 'A';

                DisplayError("Invalid option");
            } while (true);
        }

        private static void DisplayError ( string message )
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(message);

            Console.ResetColor();
        }

        private static void AddInfo ()
        {
            Console.WriteLine("Account Name: ");
            string accountNickname = ReadString(true);

            Console.WriteLine("Account Number: ");
            string accountNumber = ReadString(true);

            Console.WriteLine("Starting Balance: ");
            decimal startingBalance = ReadDecimal(0);
        }
        static decimal ReadDecimal ()
        {
            return ReadDecimal(Decimal.MinValue);
        }

        static decimal ReadDecimal ( decimal minimumBalance )
        {
            do
            {
                string value = Console.ReadLine();

                decimal result;
                if (Decimal.TryParse(value, out result) && result >= minimumBalance)
                    return result;

                if (minimumBalance != Decimal.MinValue) 
                    DisplayError("Value must be at least " + minimumBalance); 
                else
                    DisplayError("Must be integral value");
            } while (true);
        }

        static string ReadString ( bool required )
        {
            do
            {
                string value = Console.ReadLine();

                if (!required || value != "")
                    return value;

                DisplayError("Value is required");
            } while (true);
        }
    }
}
