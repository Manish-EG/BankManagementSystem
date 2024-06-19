using System;
using System.Collections;
using System.Collections.Generic;

namespace BankManagementSystem.Model
{
    public sealed  class BankBranchModel
    {

        public string BranchName { get; set; }


        public static Hashtable IFSCCodeList = new Hashtable()
        {
            {"yeyyadi",new List<String>{ "EGIND0005670", "wrkwrk,Yeyyadi","577101","Manglore","India" } },
            {"kapikad",new List<String>{ "EGIND0005780","AjanthaBusiness","577101","Manglore","India" } }
        };
        public readonly string IFSCCode;
        public AddressModel branchAddress;
        public BankBranchModel(string branchName)
        {
            BranchName = branchName;
            List<string> IfscCodeAndAddressList = IFSCCodeList[branchName] as List<string>;
            IFSCCode = IfscCodeAndAddressList?[0];
            branchAddress = new AddressModel(IfscCodeAndAddressList?[1], int.Parse(IfscCodeAndAddressList?[2]), IfscCodeAndAddressList?[3], IfscCodeAndAddressList?[4]);
        }

    }
}

