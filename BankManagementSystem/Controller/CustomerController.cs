using BankManagementSystem.Interface;
using BankManagementSystem.Model;
using System;

namespace BankManagementSystem.Controller
{
    public sealed class CustomerController : ICustomer
    {
        public void CreateAccount(CustomerModel customer)
        {
            AccountModel.AccountNumber++;
            Program.CustomerTable.Add(AccountModel.AccountNumber, customer);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAccount created successfully!!");
            Console.WriteLine($"\nYour account number is {AccountModel.AccountNumber}");
            Console.WriteLine($"\nYour IFSC code is {customer.AccountDetails.BranchModel.IFSCCode}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void EditAccount(long accountNumber)
        {
            CustomerModel customerModel;
            customerModel = (CustomerModel)Program.CustomerTable[accountNumber];
            DisplayCustomerDetails displayCustomerDetailsObj = new DisplayCustomerDetails();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Account details:");
            displayCustomerDetailsObj.ViewDetails(accountNumber);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nSelect the field you want to update: \n1.Name\n2.DOB\n3.Address\n4.Phone Number\n5.Exit");
            Console.ForegroundColor=ConsoleColor.White;
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("Enter new name:");
                    string replaceName = Console.ReadLine();
                    customerModel.CustomerName = replaceName;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Details updated successfully\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter updated date of birth:");
                    DateTime updateDOB = Convert.ToDateTime(Console.ReadLine());
                    customerModel.DateOfBirth = updateDOB;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Details updated successfully\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 3:
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("Enter new Address:");
                    Console.Write("Location: ");
                    string updatedLocation = Console.ReadLine();

                    Console.Write("\nCity: ");
                    string updatedCity = Console.ReadLine();

                    Console.Write("\nPincode: ");
                    int updatedPincode = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nCountry: ");
                    string updatedCountry = Console.ReadLine();
                    customerModel.CustomerAddress.LocationAddress = updatedLocation;
                    customerModel.CustomerAddress.City = updatedCity;
                    customerModel.CustomerAddress.PinCode = updatedPincode;
                    customerModel.CustomerAddress.Country = updatedCountry;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Details updated successfully\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter new Phone number:");
                    long updatePhoneNumber = Convert.ToInt64(Console.ReadLine());
                    customerModel.PhoneNumber = updatePhoneNumber;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Details updated successfully\n");
                    Console.ForegroundColor = ConsoleColor.White;
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
    }
}
