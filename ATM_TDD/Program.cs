using System;

namespace ATM_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ATM Machine");
            Atm atm = new Atm();

            do
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw $10");
                Console.WriteLine("3. Deposit $50");
                Console.WriteLine("4. Exit");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        atm.CheckBalance();
                        break;
                    case "2":
                        atm.Withdraw();
                        break;
                    case "3":
                        atm.Deposit();
                        break;
                    case "4":
                        showMenu = false;
                        break;
                    default:
                        Console.WriteLine("That is not a valid response.");
                        break;
                }
            } while (showMenu);

        }
    }
}
