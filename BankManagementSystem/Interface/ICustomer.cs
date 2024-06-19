using BankManagementSystem.Model;

namespace BankManagementSystem.Interface
{
    public interface ICustomer
    {
        void CreateAccount(CustomerModel customer);
        void ViewDetails();
        void EditDetails();
    }
}
