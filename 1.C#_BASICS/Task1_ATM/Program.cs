using System;

namespace Task1
{
    class Program
    {
        public  static void Main()
        {
            // The program should start with a welcome message and show a menu with options: show balance, deposit, withdraw, or exit.

            Console.WriteLine("Welcome to the ATM System");

            // skip authontication
            // print the menu 
            bool exit = false;
            byte choice = 0;
            int balance = 2500;

            do
            {
                Console.WriteLine("Please choose what you need.\n");

                // First choice
                Console.WriteLine("1. Show Balance");
                Console.WriteLine("2. Deposite");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit\n");

                try
                {
                    Console.Write("Enter a number from choices: ");
                    choice = byte.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("\nPlease Enter a number from the list [1, 2, 3, 4]\n");
                    continue;
                }

        
                switch(choice)
                {
                    case 1:
                        Console.WriteLine($"\nYour Balance is {balance}\n");
                        break;
                    case 2:

                        Console.Write("How much will you deposit? : ");
                        int deposite_value = int.Parse(Console.ReadLine());

                        if (deposite_value > 0 && deposite_value <= 8000)
                            balance += deposite_value;
                        else
                            Console.WriteLine("\nInvalid Operation\n");
                        

                        break;
                    case 3:
                        Console.Write("How much will you withdraw? : ");
                        int withdraw_value = int.Parse(Console.ReadLine());

                        if (withdraw_value >= 0 && withdraw_value <= balance)
                            balance -= withdraw_value;
                        else
                            Console.WriteLine("\nInvalid number!\n");

                        break;
                    case 4:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("\nInvalid Option");
                        break;
                }

            } while (!exit);

            Console.WriteLine("\nSee You later!");
        }
    
}
}