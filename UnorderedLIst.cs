// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UnorderedLIst.cs" company="Bridgelabz">
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
    /// UnorderedLIst is class for reading hte data from file
    /// and performed operation on it through LinkedList
    /// </summary>
    class UnorderedLIst
    {
        Utility util = new Utility();
        LinkedList<string> link = new LinkedList<string>();
        /// <summary>
        /// Operations the file.
        /// </summary>
        public void operationFile()
        {

            string st = util.readFile("C://Users//Bridgelabz//source//repos//DataStructure//Node.txt");
            //// split the string line with space and put in the array
            string[] data = st.Split(" ");
             for(int i=0;i<data.Length;i++)
            {
                link.addLast(data[i]);
            }
            link.readAll();
            Console.WriteLine("Enter the Element YOu want to search");
            string element = util.inputString();
            ////Searching element and if found then delete and add all data in file
            ////,if not found then add in to the list and then all data add in to the file
            bool find = link.search(element);
            if (find==true)
            {
                link.delete(element);
                Console.WriteLine(element + "Deleted");
                bool f = util.writeInFile("C://Users//Bridgelabz//source//repos//DataStructure//Node.txt", link.getLinkLis());
                if(f==true)
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
                link.addLast(element);
                Console.WriteLine(element + "Added");
                bool f = util.writeInFile("C://Users//Bridgelabz//source//repos//DataStructure//Node.txt", link.getLinkLis());
                if (f == true)
                {
                    Console.WriteLine("Write all Element in file");
                }
                else
                {
                    Console.WriteLine("Not Write in File");
                }
            }
        }
    }
}