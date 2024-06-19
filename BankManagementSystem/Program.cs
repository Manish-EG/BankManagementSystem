using System;
using System.Collections;
using BankManagementSystem.Controller;

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
                AccountController accountControllerObj = new AccountController();


                switch (choice)
                {
                   
                    case 2:
                        Console.Write("Enter the account number: ");
                        long accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the amount to deposit: ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        accountControllerObj.Deposit(accountNumber, amount);
                        break;
                    case 5:
                        string password, IFSCCode;
                        long senderAccountNumber, recipientAccountNumber;
                        Console.WriteLine("Enter your account number:");
                        senderAccountNumber = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter the password");
                        password = Console.ReadLine();
                        Console.WriteLine("Enter your recipient's account number:");
                        recipientAccountNumber = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter your recipient's account number:");
                        IFSCCode = Console.ReadLine();
                        accountControllerObj.MoneyTransfer(senderAccountNumber, recipientAccountNumber,password,IFSCCode);
                        break;
                 
                        
                }

            } while (choice != 8);
        }
    }
}
