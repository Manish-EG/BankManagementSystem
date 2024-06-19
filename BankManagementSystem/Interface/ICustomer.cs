using BankManagementSystem.Model;

namespace BankManagementSystem.Interface
{
    public interface ICustomer
    {
        void CreateAccount(CustomerModel customer);
    
        void ViewDetails(long accountNumber);
        void EditDetails(long accountNumber);
    }
}
