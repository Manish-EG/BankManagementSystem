namespace BankManagementSystem.Model
{
    public abstract class BaseEntity
    {
        protected static int _ID = 0;

        protected static int ID
        {
            get { return ++_ID; }
        }
    }
}
