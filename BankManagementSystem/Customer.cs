using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Address> CustomerAddress { get; set; }
        public long PhoneNumber { get; set; }
        public Account AccountDetails { get; set; }
        private string Email {  get; set; }
        private string Password { get; set; }

        public Customer(string name,string date,List<Address> address,long number,Account details,string email,string password) {
            CustomerName = name;
            DateOfBirth= Convert.ToDateTime(date);
            CustomerAddress = address;
            PhoneNumber = number;
            AccountDetails = details;
            Email = email;
            Password = password;
        
        }
     }
}
