using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem
{
    public  class BankBranch
    {
        public string BranchName;

     
        public Hashtable IFSCCodeList = new Hashtable()
        {
            {"Yeyyadi",new List<String>{ "EGIND0005670", "wrkwrk,Yeyyadi","577101","Manglore","India" } },
            {"Kapikad",new List<String>{ "EGIND0005780","AjanthaBusiness","577101","Manglore","India" } }
        };
        public readonly string IFSCCode;
        Address branchAddress;
        public BankBranch(string branchName)
        {
            BranchName = branchName;
            List<string> retrievedList = IFSCCodeList[branchName] as List<string>;
            IFSCCode = retrievedList?[0];
            branchAddress=new Address(retrievedList?[1], int.Parse(retrievedList?[2]), retrievedList?[3], retrievedList?[4]);
            
        }
        


        }
    }

