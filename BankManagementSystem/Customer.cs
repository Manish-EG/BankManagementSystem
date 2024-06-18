using System;

namespace BankManagementSystem
{
    interface ICustomerOperation
    {
        void CreateAccount();
        void ViewDetails();
        void EditDetails();
    }

    public class Customer : ICustomerOperation
    {
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address CustomerAddress { get; set; }
        public long PhoneNumber { get; set; }
        public Account AccountDetails { get; set; }
        private string Email {  get; set; }
        private string Password { get; set; }
       


        public void CreateAccount()
        {
 


        }
        public void EditDetails()
        {

        }
        public void ViewDetails()
        {

        }
        public static bool CustomerValidate(long accountNumber,string password) {

            if (!Program.CustomerTable.ContainsKey(accountNumber)) return false;
            if (password == "") return false;

            Customer customerObj = (Customer)Program.CustomerTable[accountNumber];

            if (customerObj.Password != password) return false;

            return true;
        }
     }
}
