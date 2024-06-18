using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    interface ICustomerOperation
    {
        void CreateAccount();
        void ViewDetails();
        void EditDetails();
    }

    public class Customer : ICustomerOperation
    {
        public string CustomerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address CustomerAddress { get; set; }
        public long PhoneNumber { get; set; }
        public Account AccountDetails { get; set; }
        private string Email {  get; set; }
        private string Password { get; set; }
       


        public void CreateAccount()
        {
 


        }
        public void EditDetails()
        {

        }
        public void ViewDetails()
        {

        }

     }
}
