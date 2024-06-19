namespace BankManagementSystem.Model
{
    public class BankModel
    {
        private static string _bankName = "EG-Bank";
        public static string BankName
        {
            get { return _bankName; }
        }

        private AddressModel Address = new AddressModel("abc", 12345, "manglore", "Denmark");

const int BankCode = 566152;

    }
}
