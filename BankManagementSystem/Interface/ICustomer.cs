namespace BankManagementSystem.Interface
{
    public interface ICustomer
    {
        void CreateAccount();
        void ViewDetails(long accountNumber);
        void EditDetails(long accountNumber);
    }
}
