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
                Customer customerObj = new Customer();
                switch (choice)
                {
                    case 2:
                        Console.Write("Enter the account number: ");
                        long accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the amount to deposit: ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        customerObj.AccountDetails.Deposit(accountNumber, amount);
                        break;
                }

            } while (choice != 8);
        }
    }
}
