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

        public void Deposit()
        {

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

        public  void ApplyAtmCard()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select the card type\n1.Debit Card\n2.Credit Card");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                case 2:
                    Console.WriteLine("You will be getting your card within 15 buissnes days");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
