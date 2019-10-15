using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sachin Kumar Maurya"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPS.CommercialDataLinkedList
{
    interface CommercialInterface
    {
        void DisplayStock();
        void DisplayAccount();
        void Buy();
        void Sell();
    }
    class AccountOperation :CommercialInterface
    {
        public void DisplayStock()
        {
            NewAccount<AccountModel> newAccount = new NewAccount<AccountModel>();
            newAccount.ReadAll();
            //string path = (@"C:\Users\Bridgelabz\source\repos\OOPS\CommercialData\CommercialList.json");
            //NewAccount<AccountModel> newAccount = new NewAccount<AccountModel>();
            //StreamReader read = new StreamReader(path);
            //var items = read.ReadToEnd();
            //var json = JsonConvert.DeserializeObject<AccountModel>(items); ;
            //double sum = 0;
            //foreach (var account in json)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Account Name:" + account.AccountName + "\n sahre number" + account.ShareNumber + "\n stock price " + account.Shareprice);
            //    sum += account.Shareprice;
            //}
            //Console.WriteLine("Total value of accounts store in database Rs." + sum);
        }
        public void DisplayAccount()
        {
            string accountname;
            while (true)
            {
                Console.WriteLine("Enter the account name for which you want to buy");
                accountname = Console.ReadLine();
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

                ////NewAccount newAccount = JsonRead.JsonReadFile();
                //List<AccountModel> accounts = newAccount.AccountList;
                //foreach (AccountModel name in accounts)
                //{
                //    if (name.AccountName.Equals(accountname))
                //    {
                //        Console.WriteLine("Account Name:" + name.AccountName + "\n sahre number" + name.ShareNumber + "\n stock price " + name.Shareprice);
                //    }
                //}
                break;

            }
        }
        public void Buy()
        {
            string accountname;
            while (true)
            {
                Console.WriteLine("Enter the account name for which you want to buy");
                accountname = Console.ReadLine();
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

                //NewAccount<AccountModel> newAccount = JsonRead.JsonReadFile();
                //List<AccountModel> accounts = newAccount.AccountList;
                //foreach (AccountModel name in accounts)
                //{
                //    if (name.AccountName.Equals(accountname))
                //    {
                //        Console.WriteLine("Enter share price buy");
                //        double price = Convert.ToDouble(Console.ReadLine());
                //        Console.WriteLine("Enter share Number You want to Buy");
                //        int Number = Convert.ToInt32(Console.ReadLine());
                //        name.ShareNumber = name.ShareNumber + Number;
                //        name.Shareprice = name.Shareprice + price;
                //    }
                   
               // }
                //FileWrite.WriteInToFile(newAccount);
                //Console.WriteLine(accountname + "had Successfully buy their share stock price");
                break;
            }

        }
        public void Sell()
        {
            string accountname;
            while (true)
            {
                Console.WriteLine("Enter the account name for which you want to Sell");
                accountname = Console.ReadLine();
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

                //NewAccount newAccount = JsonRead.JsonReadFile();
                //List<AccountModel> accounts = newAccount.AccountList;
                //foreach (AccountModel name in accounts)
                //{
                //    if (name.AccountName.Equals(accountname)) 
                //    {
                //        Console.WriteLine("Enter share number you want to buy");
                //        double price = Convert.ToDouble(Console.ReadLine());
                //        int Number = Convert.ToInt32(Console.ReadLine());
                //        name.ShareNumber = name.ShareNumber - Number;
                //        name.Shareprice = name.Shareprice - price;
                //    }
                    
                //}
                //FileWrite.WriteInToFile(newAccount);
                //Console.WriteLine(accountname + "had Successfully sell their share stock price");
                break;
            }
        }
    }
}
