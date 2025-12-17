using System;

// Create a simple console-based ATM program in C#. The program should start with a welcome message and show a menu with options: show balance, deposit, withdraw, or exit. The user can choose an action repeatedly until they exit. Use input/output, conditional statements, and loops to handle user interaction and balance management.
namespace ATM
{
    class Program2
    {
        public static void Main()
        {
            // set the variables
            string CorrectPin = "1234";
            double user1_balance = 5000.0;
            bool running = true;
            int attempts = 3;

            string pin;

            // Print hello message to the user

            // first take the user input
            do
            {
                attempts--;
                Console.Write("\nEnter Password: ");
                pin = Console.ReadLine();
                
            }
            while (pin != CorrectPin && attempts > 0);

            // Check the number of attempts and with valid password
            if (attempts == 0 && pin != CorrectPin)
            {
                Console.WriteLine("Incorrect Password Please try again.");
                return;
            }

            // start to show the Options
            while (running)
            {
                // Print the list to the user.
                Console.WriteLine("\n\nChoose An Option please.");
                Console.WriteLine("1- Show Balance");
                Console.WriteLine("2- Deposit");
                Console.WriteLine("3- Withdraw");
                Console.WriteLine("4- Exit The Program\n\n");

                // Take One Character from the user
                Console.Write("\nEnter Input: ");
                short Choice = Convert.ToInt16(Console.ReadLine());
                //Console.WriteLine(Choice);

                // Handle all options
                switch (Choice)
                {
                    
                    case 1:
                        Console.WriteLine($"\n\nYour Balance is {user1_balance}$\n");
                        break;

                    case 2:
                        Console.Write("Enter the money: ");
                        int amount = int.Parse(Console.ReadLine());

                        if (amount > 0)
                        {
                            user1_balance += amount;
                            Console.WriteLine("\nCompleted Operation.");
                        }
                        else
                        {
                            Console.WriteLine("Please Enter the Right Input.\n");
                            goto case 2;
                        }
                        break;

                    case 3:
                        // first thing we need to know how much
                        Console.Write("\nAmount: ");
                        double withdraw_value  = Convert.ToDouble(Console.ReadLine());

                        if (withdraw_value <= user1_balance && withdraw_value > 0)
                        {
                            user1_balance -= withdraw_value;
                            Console.WriteLine("\nTransaction is processing take the money");
                        }
                        else
                        {
                            Console.WriteLine("\nNo Enough balance can't process this transaction.");
                        }

                        break;

                    
                    case 4:
                        Console.WriteLine("\nSee you again.");
                        running = false;
                        break;
                    

                    default:
                        Console.WriteLine("\nIncorrect Choice Please Enter the right choice.");
                        break;
                }

                
            }
        }
    }
}