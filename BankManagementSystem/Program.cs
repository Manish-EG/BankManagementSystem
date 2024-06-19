using BankManagementSystem.Controller;
using BankManagementSystem.Model;
using System;
using System.Collections;

namespace BankManagementSystem
{
    public class Program
    {
        private static int choice;
        public static Hashtable CustomerTable = new Hashtable();
        static void DisplayOptions()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Create account");
            Console.WriteLine("2. Deposit amount");
            Console.WriteLine("3. Withdraw amount");
            Console.WriteLine("4. Check account balance");
            Console.WriteLine("5. Bank transfer");
            Console.WriteLine("6. Display details");
            Console.WriteLine("7. Edit details");
            Console.WriteLine("8. Apply for ATM card");
            Console.WriteLine("9. Exit");
            Console.WriteLine("----------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
                do
                {
                    DisplayOptions();
                    AccountController accountControllerObj = new AccountController();
                   
                    CustomerModel customerObject = new CustomerModel();
                    CustomerController customerControllerObj = new CustomerController();
                    long accountNumber, recipientAccountNumber;
                    string password, IFSCCode;
                    double amount;
                    switch (choice)
                    {
                        case 1:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Enter your name: ");
                            customerObject.CustomerName = Console.ReadLine();
                            Console.Write("Enter your date of birth (dd/mm/yyyy): ");
                            customerObject.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                            Console.Write("Enter your location: ");
                            string location = Console.ReadLine();
                            Console.Write("Enter your pincode: ");
                            int pincode = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter your city: ");
                            string city = Console.ReadLine();
                            Console.Write("Enter your country: ");
                            string country = Console.ReadLine();

                        customerObject.CustomerAddress = new AddressModel(location, pincode, city, country);

                            Console.Write("Enter your phone number: ");
                            customerObject.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Enter your email: ");
                            customerObject.Email = Console.ReadLine();
                            Console.Write("Enter your password: ");
                            customerObject.Password = Console.ReadLine();

                            string accountType = "";
                            bool typeSelected;
                            do
                            {
                                typeSelected = true;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("\nSelect account type: ");
                                Console.WriteLine("1. Savings account");
                                Console.WriteLine("2. Current account");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Enter your choice: ");
                                int choice = Convert.ToInt32(Console.ReadLine());
                                switch (choice)
                                {
                                    case 1:
                                        accountType = "Savings Account";
                                        break;
                                    case 2:
                                        accountType = "Current Account";
                                        break;
                                    default:
                                        Console.WriteLine("Select a valid option");
                                        typeSelected = false;
                                        break;
                                }
                            } while (!typeSelected);

                            //branchObject = new BankBranch();
                            string branchName = "";
                            bool branchSelected = false;
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("\nOur branches: ");
                                foreach (string branch in BankBranchModel.IFSCCodeList.Keys)
                                {
                                    Console.WriteLine($"* {branch}");
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("Enter branch: ");
                                string selectedBranch = Console.ReadLine();
                                int count = 0;

                                foreach (string branch in BankBranchModel.IFSCCodeList.Keys)
                                {
                                    count++;
                                    if (selectedBranch.Equals(branch))
                                    {
                                        branchName = branch;
                                        branchSelected = true;
                                        break;
                                    }
                                    int elementCount = BankBranchModel.IFSCCodeList.Count;
                                    if (elementCount == count)
                                    {
                                        branchSelected = false;
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Enter a valid branch name");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                            } while (!branchSelected);

                            customerObject.AccountDetails = new AccountModel(accountType, branchName);
                            customerControllerObj.CreateAccount(customerObject);
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Execption found: {e.Message}");
                        }
                        break;
                        case 2:
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Enter the account number: ");
                            accountNumber = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Enter the amount to deposit: ");
                            amount = Convert.ToDouble(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;
                            accountControllerObj.Deposit(accountNumber, amount);
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Execption found: {e.Message}");
                        }
                            break;
                    case 3:
                        Console.WriteLine("Enter your account number");
                        accountNumber = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter the password");
                         password = Console.ReadLine();
                        Console.WriteLine("Enter the amount to withdraw");
                        amount = Convert.ToDouble(Console.ReadLine());
                        if (CustomerController.CustomerValidate(accountNumber, password))
                        {
                            accountControllerObj.Withdraw(accountNumber, password, amount);

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid account number or password!!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                       
                        break;

                        case 4:
                        try { 
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Enter your account number: ");
                            accountNumber = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Enter your password: ");
                            password = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            if (CustomerController.CustomerValidate(accountNumber, password))
                            {
                                accountControllerObj.CheckBalance(accountNumber, password);

                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nInvalid account number or password!!");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Execption found: {e.Message}");
                        }
                        break;

                        case 5:
                        try { 
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Enter your account number:");
                            accountNumber = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter the password");
                            password = Console.ReadLine();
                            Console.WriteLine("Enter your recipient's account number:");
                            recipientAccountNumber = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter your recipient's account number:");
                            IFSCCode = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            accountControllerObj.MoneyTransfer(accountNumber, recipientAccountNumber, password, IFSCCode);
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Execption found: {e.Message}");
                        }
                        break;
                        case 8:
                        try { 
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Enter your account number:");
                            accountNumber = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter the password");
                            password = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            accountControllerObj.ApplyAtmCard(accountNumber, password);
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Execption found: {e.Message}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Enter your account number:");
                        accountNumber = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter your password:");
                        password = Console.ReadLine();
                        if (CustomerController.CustomerValidate(accountNumber, password))
                        {
                            customerControllerObj.ViewDetails(accountNumber);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid account number or password!!");
                            Console.ForegroundColor = ConsoleColor.White;

                        }
                        break;
                    case 7:
                        Console.WriteLine("Enter your account number:");
                        accountNumber = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter your password:");
                        password = Console.ReadLine();
                        if (CustomerController.CustomerValidate(accountNumber, password))
                        {
                            CustomerController customerController = new CustomerController();
                            customerController.EditDetails(accountNumber);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid account number or password!!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        break;    

                }

                } while (choice != 8);
           
        }
    }
}
