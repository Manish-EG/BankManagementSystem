using System;
using System.Collections;

namespace BankManagementSystem
{
    public class Program
    {
         private static int choice;
         public Hashtable CustomerTable = new Hashtable();
        static void DisplayOptions()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------");
           //write the options here
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
                switch (choice)
                {
                   
                }

            } while (choice != 8);
        }
    }
}
