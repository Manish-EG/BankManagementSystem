using System;

namespace BankManagementSystem.Model
{
    public sealed class AddressModel
    {
        public string LocationAddress { get; set; }
        private int _pinCode;
        public int PinCode
        {
            get
            {
                return _pinCode;
            }
            set
            {
                string pinCodeString = value.ToString();
                if (pinCodeString.Length < 6 || pinCodeString.Length > 6)
                {
                    throw new Exception("Invalid pincode!!");
                }
                else
                    _pinCode = value;
            }
        }
        public string City { get; set; }
        public string Country { get; set; }

        public AddressModel(string location, int pincode, string city, string country)
        {
            LocationAddress = location;
            PinCode = pincode;
            City = city;
            Country = country;
        }
    }
}
