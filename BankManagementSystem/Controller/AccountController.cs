using BankManagementSystem.Interface;
using BankManagementSystem.Model;
using System;
using System.Reflection;
namespace BankManagementSystem.Controller
{
    public sealed class AccountController:IAccount
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
            Console.WriteLine("Amount has been credited to account");
        }

        public void Withdraw(long accountNumber, string password, double amount)
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
            Console.WriteLine($"\nYour current balance is {customer.AccountDetails.Balance} rupees");

        }

        public void MoneyTransfer(long senderAccountNumber,long recipientAccountNumber, string password,string IFSCCode)
        {
            CustomerModel senderCustomer,recipientCustomer;
            senderCustomer = (CustomerModel)Program.CustomerTable[senderAccountNumber];
            recipientCustomer = (CustomerModel)Program.CustomerTable[recipientAccountNumber];
            if (CustomerController.CustomerValidate(senderAccountNumber,password) && Program.CustomerTable.ContainsKey(recipientAccountNumber) && recipientCustomer.AccountDetails.branchModel.IFSCCode==IFSCCode )
            {
                
                double amount;
                Console.WriteLine("Enter the ammount");
                amount=Convert.ToDouble(Console.ReadLine());
                
                if (senderCustomer.AccountDetails.Balance > amount )
                {
                    Deposit(senderAccountNumber, amount);
                    Withdraw(senderAccountNumber,password,amount);
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

        public  void ApplyAtmCard(long accountNumber,string password)
        {
            if(CustomerController.CustomerValidate(accountNumber,password))
            { 

            int choice;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter your choice\n1.Debit Card\n2.Credit Card");
            Console.ForegroundColor = ConsoleColor.White;
            choice =Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You will get your Credit/Debit card within 15 buisness days,Thank you.");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid credential");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        
    }
}
