using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Customer customer;
            Console.WriteLine("Enter your account number:");
            long accountNumber=Convert.ToInt64(Console.ReadLine());
            Program program = new Program();
            if (program.CustomerTable.ContainsKey(accountNumber))
            {
                customer=(Customer)program.CustomerTable[accountNumber];
                Console.WriteLine("---------------EG BANK---------------");
                Console.WriteLine("Customer name: " + customer.CustomerName);
                Console.WriteLine("Customer DOB: " + customer.DateOfBirth);
                Console.WriteLine("Customer address: " + customer.CustomerAddress.LocationAddress+", "+ customer.CustomerAddress.City + ", \n" + customer.CustomerAddress.PinCode + ", " + customer.CustomerAddress.Country);
                Console.WriteLine("Customer phone number: " + customer.PhoneNumber);
                Console.WriteLine("Account number: " + customer.AccountDetails.AccountNumber);
                Console.WriteLine("Account type: " + customer.AccountDetails.AccountType);
                Console.WriteLine("Date created: " + customer.AccountDetails.DateOfCreation);
                Console.WriteLine("Branch Name: " + customer.AccountDetails.Branch.BranchName);
                Console.WriteLine("IFSC code: " + customer.AccountDetails.Branch.IFSCCode);
                Console.WriteLine("Branch Address: "+customer.AccountDetails.Branch.branchAddress.LocationAddress + ", " + customer.AccountDetails.Branch.branchAddress.City + ", \n" + customer.AccountDetails.Branch.branchAddress.PinCode + ", " + customer.AccountDetails.Branch.branchAddress.Country);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Account number not found!! Please check the number you've typed.");
                Console.ForegroundColor= ConsoleColor.White;

            }
        }

     }
}
