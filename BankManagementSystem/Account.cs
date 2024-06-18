using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    public class Account
    {
        public string AccountType { get; set; }
        public int AccountNumber{get; set; }
        public double Balance{ get; set; }
        public DateTime DateOfCreation { get; set; }
        public BankBranch Branch {  get; set; }

        public Account(string type,int number,double balance,string date,BankBranch branch ) { 
            AccountType = type;
            AccountNumber = number;
            Balance = balance;
            DateOfCreation=Convert.ToDateTime(date);
            Branch = branch;
        }
    }
}
