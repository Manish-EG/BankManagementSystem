namespace BankManagementSystem
{
    public class Address
    {
        public string LocationAddress { get; set; }
        public int PinCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address(string location,int pincode,string city,string country) {
            LocationAddress = location;
            PinCode = pincode;
            City = city;
            Country = country;
        }
    }
}
