using System;

namespace BankManagementSystem
{
    interface IAccountOperation
    {
        void Deposit(long accountNumber, double amount);
        void Withdraw();
        void CheckBalance();
        void MoneyTransfer();
        void ApplyAtmCard();
    }
    public class Account : IAccountOperation
    {
        public string AccountType { get; set; }
        public long AccountNumber { get; set; }
        public double Balance { get; set; }
        public DateTime DateOfCreation { get; set; }
        public BankBranch Branch { get; set; }

        public Account(string type, string branch)
        {
            AccountType = type;
            Balance = 0;
            DateOfCreation = System.DateTime.Now;
            Branch = new BankBranch(branch);
        }

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
            Customer customerObj = (Customer)Program.CustomerTable[accountNumber];
            customerObj.AccountDetails.Balance = amount;
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
