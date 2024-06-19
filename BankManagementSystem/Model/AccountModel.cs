using System;
using System.Security.Cryptography;

namespace BankManagementSystem.Model
{
    public sealed class AccountModel
    {
        public string AccountType { get; set; }
        private static long _accountNumber = 110000; 
        public double Balance { get; set; }
        public DateTime DateOfCreation { get; set; }
        public BankBranchModel branchModel { get; set; }

        public AccountModel(string type, string branch)
        {
            AccountType = type;
            Balance = 0;
            DateOfCreation = System.DateTime.Now;
            branchModel = new BankBranchModel(branch);
        }
        public static long AccountNumber
        {
            get { return ++_accountNumber; }
        }
    }
}
