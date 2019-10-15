

namespace OOPS.CommercialDataLinkedList
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    class JsonRead
    {
        public static NewAccount<AccountModel> JsonReadFile()
        {
            string path = (@"C:\Users\Bridgelabz\source\repos\OOPS\CommercialData\CommercialList.json");
            StreamReader read = new StreamReader(path);
            string json = read.ReadToEnd();
            //// Convert json format to string format.
            NewAccount<AccountModel> account = JsonConvert.DeserializeObject<NewAccount<AccountModel>>(json);
            read.Close();
            return account;
        }
    }
}
