using BankManagementSystem.Interface;
using BankManagementSystem.Model;
using System;
namespace BankManagementSystem.Controller
{
    public sealed class AccountController : IAccount
    {
        public void Deposit(long accountNumber, double amount)
        {
            if (!Program.CustomerTable.ContainsKey(accountNumber))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid account number");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (amount <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Amount needs to be greater than zero");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            CustomerModel customerModelObj = (CustomerModel)Program.CustomerTable[accountNumber];
            customerModelObj.AccountDetails.Balance += amount;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Amount has been credited to account");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Withdraw(long accountNumber, string password, double amount)
        {
            if (Validation.ValidateAccount(accountNumber, password))
            {

                CustomerModel customerObject = (CustomerModel)Program.CustomerTable[accountNumber];
                if (amount > customerObject.AccountDetails.Balance)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Please enter the amount less than  the balance amount {customerObject.AccountDetails.Balance}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (amount <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid entry");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    customerObject.AccountDetails.Balance -= amount;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Withdraw Succesfull");
                    Console.ForegroundColor = ConsoleColor.White;
                }


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Withdraw unsuccesfull due wrong credentials");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void CheckBalance(long accountNumber, string password)
        {
            CustomerModel customer = (CustomerModel)Program.CustomerTable[accountNumber];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nYour current balance is {customer.AccountDetails.Balance} rupees");
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void MoneyTransfer(long senderAccountNumber, long recipientAccountNumber, string password, string IFSCCode)
        {
            CustomerModel senderCustomer, recipientCustomer;
            senderCustomer = (CustomerModel)Program.CustomerTable[senderAccountNumber];
            recipientCustomer = (CustomerModel)Program.CustomerTable[recipientAccountNumber];
            if (Validation.ValidateAccount(senderAccountNumber, password) && Program.CustomerTable.ContainsKey(recipientAccountNumber) && recipientCustomer.AccountDetails.BranchModel.IFSCCode == IFSCCode)
            {

                double amount;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter the ammount");
                amount = Convert.ToDouble(Console.ReadLine());
                if (senderCustomer.AccountDetails.Balance > amount)
                {
                    Withdraw(senderAccountNumber, password, amount);
                    Deposit(recipientAccountNumber, amount);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Amount Transfered to recipients account successfully!");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Transaction Declined! Insufficient Balance.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Account not found!! Please check the Account number/Password you've typed.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

}  
    
    