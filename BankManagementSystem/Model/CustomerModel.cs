using System;

namespace BankManagementSystem.Model
{
    public class CustomerModel
    {
        private string _customerName;
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public AddressModel CustomerAddress { get; set; }
        public long PhoneNumber { get; set; }
        public AccountModel AccountDetails { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
