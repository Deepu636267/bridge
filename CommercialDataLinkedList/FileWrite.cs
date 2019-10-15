using Newtonsoft.Json;
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
    using System.IO;
    class FileWrite
    {
        public static void WriteInToFile(NewAccount<AccountModel> newAccount)
        {
            string path = (@"C:\Users\Bridgelabz\source\repos\OOPS\CommercialData\CommercialList.json");
            
            var writeData = JsonConvert.SerializeObject(newAccount);
            StreamWriter stream = new StreamWriter(path);
            stream.Write(writeData);
            
            stream.Close();
        }
    }
}
