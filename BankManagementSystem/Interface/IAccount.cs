


namespace BankManagementSystem.Interface
{
    public interface IAccount
    {
        void Deposit(long accountNumber, double amount);
        void Withdraw();
        void CheckBalance();
        void MoneyTransfer();
        void ApplyAtmCard();
    }
}
