using System;

namespace BankManagementSystem.Model
{
    public sealed class AccountModel
    {
        public string AccountType { get; set; }
        public static long AccountNumber = 110000; 
        public double Balance { get; set; }
        public DateTime DateOfCreation { get; set; }
        public BankBranchModel BranchModel { get; set; }

        public AccountModel(string type, string branch)
        {
            AccountType = type;
            Balance = 0;
            DateOfCreation = System.DateTime.Now;
            BranchModel = new BankBranchModel(branch);
        }
    }
}
