using System;

namespace BankManagementSystem.Controller
{
    public class ATMCard
    {
        public void ApplyAtmCard(long accountNumber, string password)
        {
            if (Validation.ValidateAccount(accountNumber, password))
            {

                int choice;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter your choice\n1.Debit Card\n2.Credit Card");
                Console.ForegroundColor = ConsoleColor.White;
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You will get your Credit/Debit card within 15 buisness days,Thank you.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid credential");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return;
        }
    }
}
