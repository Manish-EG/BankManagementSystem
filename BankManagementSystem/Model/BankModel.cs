namespace BankManagementSystem.Model
{
    public class BankModel
    {
        private static string _bankName = "EG-Bank";
        public static string BankName
        {
            get { return _bankName; }
        }

        private AddressModel Address = new AddressModel("WrkWrk", 453217, "Horsens", "Denmark");

const int BankCode = 566152;

    }
}
