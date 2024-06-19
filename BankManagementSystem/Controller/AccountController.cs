using BankManagementSystem.Interface;
using BankManagementSystem.Model;
using System;
using System.Reflection;
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

        public void Withdraw()
        {

        }

        public void CheckBalance()
        {

        }

        public void MoneyTransfer()
        {
            CustomerModel senderCustomer,recipientCustomer;
            string password,IFSCCode;
            long senderAccountNumber, recipientAccountNumber;
            Console.WriteLine("Enter your account number:");
            senderAccountNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the password");
            password = Console.ReadLine();
            Console.WriteLine("Enter your recipient's account number:");
            recipientAccountNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your recipient's account number:");
            IFSCCode = Console.ReadLine();
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
                    Withdraw(senderAccountNumber,amount);
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

        public  void ApplyAtmCard()
        {

            int choice;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter your choice\n1.Debit Card\n2.Credit Card");
            Console.ForegroundColor = ConsoleColor.White;
            choice =Convert.ToInt32(Console.ReadLine());
            switch (choice) {
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
                    break ;
            }

        }

        
    }
}
