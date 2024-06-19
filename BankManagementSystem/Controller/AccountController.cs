using BankManagementSystem.Interface;
using BankManagementSystem.Model;
using System;
namespace BankManagementSystem.Controller
{
    public class AccountController:IAccount
    {
        public void Deposit(long accountNumber, double amount)
        {
            if (!Program.CustomerTable.ContainsKey(accountNumber))
            {
                Console.WriteLine("Invalid account number");
                return;
            }
            if (amount <= 0)
            {
                Console.WriteLine("Amount needs to be greater than zero");
                return;
            }
            CustomerModel customerModelObj = (CustomerModel)Program.CustomerTable[accountNumber];
            customerModelObj.AccountDetails.Balance = amount;
            Console.WriteLine("Amount has been credited to your account");
        }

        public void Withdraw(long accountNumber, string password, int amount)
        {
            if (CustomerController.CustomerValidate(accountNumber, password))
            {

                CustomerModel customerObject = (CustomerModel)Program.CustomerTable[accountNumber];
                customerObject.AccountDetails.Balance -= amount;
                Console.WriteLine("Withdraw Succesfull");

            }
            else
                Console.WriteLine("Withdraw unsuccesfull due wrong credentials");
        }

        public void CheckBalance(long accountNumber,string password)
        {
            CustomerModel customer = (CustomerModel)Program.CustomerTable[accountNumber];
            Console.WriteLine($"Your current balance is {customer.AccountDetails.Balance}");

        }

        public void MoneyTransfer()
        {
            CustomerModel customer;
            string password;
            long senderAccountNumber, recipientAccountNumber;
            Console.WriteLine("Enter your account number:");
            senderAccountNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the password");
            password = Console.ReadLine();
            Console.WriteLine("Enter your recipient's account number:");
            recipientAccountNumber = Convert.ToInt64(Console.ReadLine());
            
            if (CustomerController.CustomerValidate(senderAccountNumber,password) && Program.CustomerTable.ContainsKey(recipientAccountNumber))
            {
                int amount;
                Console.WriteLine("Enter the ammount");
                Program.CustomerTable.ContainsKey(senderAccountNumber);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Account not found!! Please check the Account number/Password you've typed.");
                Console.ForegroundColor = ConsoleColor.White;

            }

        }

        public  void ApplyAtmCard()
        {

            int choice;
            Console.WriteLine("Enter your choice\n1.Debit Card\n2.Credit Card");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                case 2:
                    Console.WriteLine("You will get your Credit/Debit card within 15 buisness days,Thank you.");
                    break;
                default:
                    Console.WriteLine("Invalid choice!!");
                    break ;
            }

        }

        
    }
}
