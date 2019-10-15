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
    class CreateAccount
    {
        
        public void Create()
        {
            string accountname = null;
            int sharenumber = 0;
            double shareprice = 0;
            Console.WriteLine("Enter Name to create an account");
            accountname = Console.ReadLine();
            while (true)
            {
                if (Utility.ContainsCharacter(accountname))
                {
                    Console.WriteLine("no character allowed");
                    continue;
                }
                if (Utility.ConatainsDigit(accountname))
                {
                    Console.WriteLine("no digit allowed");
                    continue;
                }
                if (Utility.CheckString(accountname))
                {
                    Console.WriteLine("you should specify name");
                    continue;
                }
                break;
            }
            AccountModel.CreateAccountObject(accountname, sharenumber, shareprice);
            Console.WriteLine("New Account has been created with name " + accountname);
        }
    }
}

