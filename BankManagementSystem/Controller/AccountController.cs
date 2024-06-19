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

        public void Withdraw()
        {

        }

        public void CheckBalance()
        {

        }

        public void MoneyTransfer()
        {

        }

        public void ApplyAtmCard()
        {

        }
    }
}
