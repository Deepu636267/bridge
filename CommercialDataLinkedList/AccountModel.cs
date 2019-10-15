using System;
using System.Collections.Generic;
using System.Text;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sachin Kumar Maurya"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPS.CommercialDataLinkedList
{
    class AccountModel
    {
            public AccountModel(string accountname, int sharenumber, double shareprice)
            {
                AccountName = accountname;
                ShareNumber = sharenumber;
                Shareprice = shareprice;
            }

            public string AccountName { get; set; }
            public int ShareNumber { get; set; }
            public double Shareprice { get; set; }
            public static void CreateAccountObject(string accountname, int sharenumber, double shareprice)
            {
                AccountModel account = new AccountModel(accountname, sharenumber, shareprice);
                NewAccount<AccountModel> newAccount = JsonRead.JsonReadFile();
                //newAccount.AccountList.AddLast(account);
                FileWrite.WriteInToFile(newAccount);
                Console.WriteLine("Account had been successfully created");
            }
    }
}
