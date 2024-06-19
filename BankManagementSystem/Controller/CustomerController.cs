using BankManagementSystem.Interface;
using BankManagementSystem.Model;
using System;

namespace BankManagementSystem.Controller
{
    public class CustomerController: ICustomer
    {
        public void CreateAccount(CustomerModel customer)
        {

            Program.CustomerTable.Add(customer.AccountDetails.AccountNumber, customer);
            Console.WriteLine("\nAccount created successfully!!");


        }
        public void EditDetails(long accountNumber)
        {
            CustomerModel customerModel;
            customerModel = (CustomerModel)Program.CustomerTable[accountNumber];
                Console.WriteLine("Account details:");
                Console.ForegroundColor = ConsoleColor.Blue;
                ViewDetails(accountNumber);
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("\nSelect the field you want to update: \n1.Name\n2.DOB\n3.Address\n4.Phone Number\n5.Exit");
                Console.ForegroundColor = ConsoleColor.White;
                int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter new name:");
                    string replaceName = Console.ReadLine();
                    customerModel.CustomerName = replaceName;
                    break;
                case 2:
                    Console.WriteLine("Enter updated date of birth:");
                    DateTime updateDOB = Convert.ToDateTime(Console.ReadLine());
                    customerModel.DateOfBirth = updateDOB;
                    break;
                case 3:

                    Console.WriteLine("Enter new Address:");
                    Console.Write("Location: ");
                    string updatedLocation = Console.ReadLine();
                    customerModel.CustomerAddress.LocationAddress = updatedLocation;
                    Console.Write("\nCity: ");
                    string updatedCity = Console.ReadLine();
                    customerModel.CustomerAddress.City = updatedCity;
                    Console.Write("\nPincode: ");
                    int updatedPincode = Convert.ToInt32(Console.ReadLine());
                    customerModel.CustomerAddress.PinCode = updatedPincode;
                    Console.Write("\nCountry: ");
                    string updatedCountry = Console.ReadLine();
                    customerModel.CustomerAddress.Country = updatedCountry;
                    break;
                case 4:
                    Console.WriteLine("Enter new Phone number:");
                    long updatePhoneNumber = Convert.ToInt64(Console.ReadLine());
                    customerModel.PhoneNumber = updatePhoneNumber;
                    break;
                case 5:
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter correct option!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            
            

        }
        public void ViewDetails(long accountNumber)
        {

            CustomerModel customer;
            
                customer = (CustomerModel)Program.CustomerTable[accountNumber];
                Console.WriteLine("---------------EG BANK---------------");
                Console.WriteLine("Customer name: " + customer.CustomerName);
                Console.WriteLine("Customer DOB: " + customer.DateOfBirth);
                Console.WriteLine("Customer address: " + customer.CustomerAddress.LocationAddress + ", " + customer.CustomerAddress.City + ", \n" + customer.CustomerAddress.PinCode + ", " + customer.CustomerAddress.Country);
                Console.WriteLine("Customer phone number: " + customer.PhoneNumber);
                Console.WriteLine("Account number: " + customer.AccountDetails.AccountNumber);
                Console.WriteLine("Account type: " + customer.AccountDetails.AccountType);
                Console.WriteLine("Date created: " + customer.AccountDetails.DateOfCreation);
                Console.WriteLine("Branch Name: " + customer.AccountDetails.branchModel.BranchName);
                Console.WriteLine("IFSC code: " + customer.AccountDetails.branchModel.IFSCCode);
                Console.WriteLine("Branch Address: " + customer.AccountDetails.branchModel.branchAddress.LocationAddress + ", " + customer.AccountDetails.branchModel.branchAddress.City + ", \n" + customer.AccountDetails.branchModel.branchAddress.PinCode + ", " + customer.AccountDetails.branchModel.branchAddress.Country);
            
            

        }
        public static bool CustomerValidate(long accountNumber, string password)
        {

            if (!Program.CustomerTable.ContainsKey(accountNumber)) return false;
            if (password == "") return false;

            CustomerModel customerObj = (CustomerModel)Program.CustomerTable[accountNumber];

            if (customerObj.Password != password) return false;

            return true;
        }
    }
}
