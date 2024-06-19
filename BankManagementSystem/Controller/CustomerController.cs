using BankManagementSystem.Interface;
using BankManagementSystem.Model;

namespace BankManagementSystem.Controller
{
    public class CustomerController: ICustomer
    {
        public void CreateAccount()
        {



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

            if (customerObj.Password != password) return false;

            return true;
        }
    }
}
