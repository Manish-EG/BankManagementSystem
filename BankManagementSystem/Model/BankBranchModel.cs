using System;
using System.Collections;
using System.Collections.Generic;

namespace BankManagementSystem.Model
{
    public class BankBranchModel
    {
        public string BranchName;

        public string BranchName { get; set; }


        public static Hashtable IFSCCodeList = new Hashtable()
        {
            {"Yeyyadi",new List<String>{ "EGIND0005670", "wrkwrk,Yeyyadi","577101","Manglore","India" } },
            {"Kapikad",new List<String>{ "EGIND0005780","AjanthaBusiness","577101","Manglore","India" } }
        };
        public readonly string IFSCCode;
        public AddressModel branchAddress;
        public BankBranchModel(string branchName)
        {
            BranchName = branchName;
            List<string> retrievedList = IFSCCodeList[branchName] as List<string>;
            IFSCCode = retrievedList?[0];
            branchAddress = new AddressModel(retrievedList?[1], int.Parse(retrievedList?[2]), retrievedList?[3], retrievedList?[4]);
        }

    }
}

