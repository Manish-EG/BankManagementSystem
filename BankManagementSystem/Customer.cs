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
        public Account AccountADetails { get; set; }
        private string Email {  get; set; }
        private string Password {  get; set; }
     }
}
