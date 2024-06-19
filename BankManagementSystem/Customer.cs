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
        void CreateAccount(Customer customer);
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
        private string Password { get;set; }

        public Customer(string customerName, DateTime dateOfBirth, Address customerAddress, long phoneNumber, Account accountDetails, string email, string password) 
        { 
            CustomerName = customerName;
            DateOfBirth = dateOfBirth;  
            CustomerAddress = new Address(customerAddress.LocationAddress, customerAddress.PinCode, customerAddress.City, customerAddress.Country);
            PhoneNumber = phoneNumber;
            AccountDetails = new Account(accountDetails.AccountType, accountDetails.Branch.BranchName);
            Email = email;
            Password = password;
        
        }


        public void CreateAccount(Customer customer)
        {
            Program program = new Program();
            program.CustomerTable.Add(customer.AccountDetails.AccountNumber,customer);
        }
        public void EditDetails()
        {

        }
        public void ViewDetails()
        {

        }

     }
}
