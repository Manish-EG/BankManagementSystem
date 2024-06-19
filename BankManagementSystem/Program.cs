using System;
using System.Collections;
using BankManagementSystem.Controller;

namespace BankManagementSystem
{
    public class Program
    {
        private static int choice;
        public static Hashtable CustomerTable = new Hashtable();
        static void DisplayOptions()
        {
            Console.ForegroundColor = ConsoleColor.Green;
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
            Console.Write("Enter your choice:");
            choice = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            do
            {
                DisplayOptions();
                AccountController accountControllerObj = new AccountController();
                Account accountObject;
                Address addressObject;
                BankBranch branchObject;
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your name: ");
                        string customerName = Console.ReadLine();
                        Console.Write("Enter your date of birth: ");
                        DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Enter your location: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter your pincode: ");
                        int pincode = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter your city: ");
                        string city = Console.ReadLine();
                        Console.Write("Enter your country: ");
                        string country = Console.ReadLine();

                        addressObject = new Address(address, pincode, city, country);

                        Console.Write("Enter your phone number: ");
                        long phoneNumber = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Enter your email: ");
                        string email = Console.ReadLine();
                        Console.Write("Enter your password: ");
                        string password = Console.ReadLine();

                        string accountType = "";
                        bool typeSelected;
                        do
                        {
                            typeSelected = true;
                            Console.WriteLine("\nSelect account type: ");
                            Console.WriteLine("1. Savings account");
                            Console.WriteLine("2. Current account");
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

                        branchObject = new BankBranch();
                        string branchName = "";
                        bool branchSelected = false;
                        do
                        {
                            Console.WriteLine("\nOur branches: ");
                            foreach (string branch in branchObject.IFSCCodeList.Keys)
                            {
                                Console.WriteLine($"* {branch}");
                            }

                            Console.Write("Enter branch: ");
                            string selectedBranch = Console.ReadLine();
                            int count = 0;
                        
                            foreach (string branch in branchObject.IFSCCodeList.Keys)
                            {
                                count++;
                                if (selectedBranch.Equals(branch))
                                {
                                    branchName = branch;
                                    branchSelected = true;
                                    break;
                                }
                                int elementCount = branchObject.IFSCCodeList.Count;
                                if (elementCount == count)
                                {
                                    branchSelected = false;
                                    Console.WriteLine("Enter a valid branch name");
                                }
                            }
                        }while (!branchSelected);

                        accountObject = new Account(accountType, branchName);

                        Customer customer = new Customer(customerName, dateOfBirth, addressObject, phoneNumber, 
                            accountObject, email, password);
                        customer.CreateAccount(customer);
                        break;
                    case 2:
                        Console.Write("Enter the account number: ");
                        long accountNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the amount to deposit: ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        accountControllerObj.Deposit(accountNumber, amount);
                        break;

                    case 4:
                        Console.Write("Enter your account number: ");
                        int accountNumber = Convert.ToInt32(Console.ReadLine());
                        Program program = new Program();
                        if(program.CustomerTable.ContainsKey(accountNumber))
                        {
                            customer = (Customer)program.CustomerTable[accountNumber];
                            accountObject = (Account)customer.AccountDetails;
                            accountObject.CheckBalance(accountNumber);
                        }
                        else
                        {
                            Console.WriteLine("\nAccount number doesnot exist!!");
                        }
                        break;
                   
                }

            } while (choice != 8);
        }
    }
}
