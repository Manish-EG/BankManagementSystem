using BankManagementSystem.Interface;
using BankManagementSystem.Model;
using System;

namespace BankManagementSystem.Controller
{
    public sealed class CustomerController: ICustomer
    {
        public void CreateAccount(CustomerModel customer)
        {

            Program.CustomerTable.Add(customer.AccountDetails.AccountNumber, customer);
            Console.WriteLine("\nAccount created successfully!!");

        }
        public void EditDetails()
        {

        }
        public void ViewDetails()
        {

        }
        public static bool CustomerValidate(long accountNumber, string password)
        {

            if (!Program.CustomerTable.ContainsKey(accountNumber)) return false;
            if (password == "") return false;

            CustomerModel customerObj = (CustomerModel)Program.CustomerTable[accountNumber];

            if (!customerObj.Password.Equals(password)) return false;

            return true;
        }
    }
}
