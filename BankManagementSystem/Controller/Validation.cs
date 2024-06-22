using BankManagementSystem.Model;
using System.Text.RegularExpressions;

namespace BankManagementSystem.Controller
{
    public class Validation
    {
        public static bool ValidateAccount(long accountNumber, string password)
        {

            if (!Program.CustomerTable.ContainsKey(accountNumber)) return false;
            if (password == "") return false;

            CustomerModel customerObj = (CustomerModel)Program.CustomerTable[accountNumber];

            if (!customerObj.Password.Equals(password)) return false;

            return true;
        }

        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
