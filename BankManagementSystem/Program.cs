using System;
using System.Collections;

namespace BankManagementSystem
{
    public class Program
    {
         private static int choice;
         public static Hashtable CustomerTable = new Hashtable();
        static void DisplayOptions()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Create account");
            Console.WriteLine("2. Deposit amount");
            Console.WriteLine("3. Withdraw amount");
            Console.WriteLine("4. Check account balance");
            Console.WriteLine("5. Bank transfer");
            Console.WriteLine("6. Display details");
            Console.WriteLine("7. Edit details");
            Console.WriteLine("8. Apply for ATM card");
            Console.WriteLine("9. Exit");
            Console.WriteLine("----------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your choice:");
            choice = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            do
            {
                DisplayOptions();
                Customer customerObject = new Customer();
                switch (choice)
                {
                    case 3:
                        Console.WriteLine("Enter your account number");
                        long accountNumber = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter the password");
                        string password = Console.ReadLine();
                        Console.WriteLine("Enter the amount to withdraw");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        customerObject.AccountDetails.Withdraw(accountNumber, password, amount);
                        break;
                }

            } while (choice != 8);
        }
    }
}
