using BankManagementSystem.Interface;
using BankManagementSystem.Model;
using System;

namespace BankManagementSystem.Controller
{
    public class DisplayCustomerDetails: IDisplayCustomerDetails
    {
        public void ViewDetails(long accountNumber)
        {
            CustomerModel customer;
            customer = (CustomerModel)Program.CustomerTable[accountNumber];
            Program.DisplayBankName();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Customer name: " + customer.CustomerName);
            Console.WriteLine("Customer DOB: " + customer.DateOfBirth);
            Console.WriteLine("Customer address: " + customer.CustomerAddress.LocationAddress + ", " + customer.CustomerAddress.City + ", \n" + customer.CustomerAddress.PinCode + ", " + customer.CustomerAddress.Country);
            Console.WriteLine("Customer phone number: " + customer.PhoneNumber);
            Console.WriteLine("Account number: " + accountNumber);
            Console.WriteLine("Account type: " + customer.AccountDetails.AccountType);
            Console.WriteLine("Date created: " + customer.AccountDetails.DateOfCreation);
            Console.WriteLine("Branch Name: " + customer.AccountDetails.BranchModel.BranchName);
            Console.WriteLine("IFSC code: " + customer.AccountDetails.BranchModel.IFSCCode);
            Console.WriteLine("Branch Address: " + customer.AccountDetails.BranchModel.branchAddress.LocationAddress + ", " + customer.AccountDetails.BranchModel.branchAddress.City + ", \n" + customer.AccountDetails.BranchModel.branchAddress.PinCode + ", " + customer.AccountDetails.BranchModel.branchAddress.Country);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
