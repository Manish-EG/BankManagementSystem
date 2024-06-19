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
        void CheckBalance();
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

        public void Withdraw(long accountNumber,string password,int amount)
        {
           
            if ( CustomerValidate(accountNumber,password)) {
              
                Customer customerObject = (Customer)Program.CustomerTable[accountNumber];
                customerObject.AccountDetails.Balance-=amount;
                Console.WriteLine("Withdraw Succesfull");

            }
           

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
