using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    interface IAccountOperation
    {
        void Deposit();
        void Withdraw();
        void CheckBalance(long accountNumber);
        void MoneyTransfer();
        void ApplyAtmCard();
    }
    public class Account : IAccountOperation
    {
        public string AccountType { get; set; }
        public long AccountNumber{get; set; }
        public double Balance { get; set; }
        public DateTime DateOfCreation { get; set; }
        public BankBranch Branch {  get; set; }

        public Account(string type,string branch ) { 
            AccountType = type;
            Balance = 0;
            DateOfCreation=System.DateTime.Now;
            Branch =new BankBranch(branch);
        }

        public void Deposit()
        {

        }

        public void Withdraw()
        {

        }

        public void CheckBalance(long accountNumber)
        {
            Program program = new Program();
            Customer customer = (Customer)program.CustomerTable[accountNumber];
            Console.WriteLine($"Your current balance is {customer.AccountDetails.Balance}");

        }

        public void MoneyTransfer()
        {

        }

        public void ApplyAtmCard()
        {

        }
    }
}
