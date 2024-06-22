using BankManagementSystem.Controller;
using System;

namespace BankManagementSystem.Model
{
    public sealed class CustomerModel
    {
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        private long _phoneNumber;
        public long PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                string phoneNumberString = value.ToString();
                if (phoneNumberString.Length != 10)
                {
                    throw new Exception("Invalid phone number!!");
                }
                else
                    _phoneNumber = value;
            }
        }
        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                CustomerController customerControllerObject = new CustomerController();
                if(Validation.ValidateEmail(value))
                {
                    _email = value;
                }
                else
                {
                    throw new Exception("Invalid Email-Id!!");
                }
            }
        }
        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                string passwordString = value.ToString();
                if (passwordString.Length < 4)
                {
                    throw new Exception("Password must contain atleast 4 characters!!");
                }
                else
                    _password = value;
            }
        }
        public AddressModel CustomerAddress { get; set; }
        public AccountModel AccountDetails { get; set; }
    }
}
