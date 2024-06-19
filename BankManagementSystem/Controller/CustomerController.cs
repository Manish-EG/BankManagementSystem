using BankManagementSystem.Interface;
using BankManagementSystem.Model;
using System;
using System.Text.RegularExpressions;

namespace BankManagementSystem.Controller
{
    public sealed class CustomerController: ICustomer
    {
        public void CreateAccount(CustomerModel customer)
        {
            AccountModel.AccountNumber++;
            Program.CustomerTable.Add(AccountModel.AccountNumber, customer);
            Console.WriteLine("\nAccount created successfully!!");
            Console.WriteLine($"\nYour account number is {AccountModel.AccountNumber}");
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

        public bool IsValidEmail(string email)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
