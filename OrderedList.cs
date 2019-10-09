// --------------------------------------------------------------------------------------------------------------------
// <copyright file=OrderedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sachin Kumar Maurya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// OrderedList is a class with OperationOrderedFile() method
    /// to read data from file and operate on him
    /// </summary>
    class OrderedList
    {
        LinkedList<int> list = new LinkedList<int>();
        Utility util = new Utility();
        /// <summary>
        /// Operations the ordered file.
        /// </summary>
        public void operationOrderedFile()
        {
          ////Reading the file  
            string st = util.readFile("C://Users//Bridgelabz//source//repos//DataStructure//Node1.txt");
            string[] str = st.Split(" ");
            for (int i=0;i<str.Length-1;i++)
            {
                ////adding in too list 
                list.addLast(Convert.ToInt32(str[i]));
            }
            Console.WriteLine("Enter the Element That You Want To Search");
            int element = util.inputInteger();
            ////Searching element and if found then delete and add all data in file
            ////,if not found then add in to the list and then all data add in to the file
            bool b=list.search(element);
            if(b==true)
            {
                Console.WriteLine(" Element Found And Element Deleted");
                list.delete(element);
                bool f=util.writeInFile("C://Users//Bridgelabz//source//repos//DataStructure//Node1.txt", list.getLinkLis());
                list.readAll();
                if (f == true)
                {
                    Console.WriteLine("Write all Element in File");
                }
                else
                {
                    Console.WriteLine("Not Write in File");
                }
            }
            else
            {
                Console.WriteLine("Element Not Found And Element added");
                list.sortedInsert(element);
                bool f = util.writeInFile("C://Users//Bridgelabz//source//repos//DataStructure//Node1.txt", list.getLinkLis());
                list.readAll();
                if (f == true)
                {
                    Console.WriteLine("Write all Element in File");
                }
                else
                {
                    Console.WriteLine("Not Write in File");
                }
            }
        }
    }
}