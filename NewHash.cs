// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NewHash.cs" company="Bridgelabz">
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
    /// NewHash is class for mainting the hash function 
    /// with property of Collision solve by chaining
    /// </summary>
    class NewHash
    {
        public LinkedList<int>[] hashTable = new LinkedList<int>[11];
        Utility util = new Utility();
        /// <summary>
        /// get the index value by dividing 11.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        public int hashCode(int x)
        {
            return x % 11;
        }
        /// <summary>
        /// Adds to hash table.
        /// </summary>
        /// <param name="x">The x.</param>
        public void addToHashTable(int x)
        {
            int index = hashCode(x);

            if (hashTable[index] == null)
            {
                hashTable[index] = new LinkedList<int>();
                hashTable[index].addLast(x);
            }
            else
            {
                hashTable[index].addLast(x);
            }
        }
        /// <summary>
        /// Prints the hash table.
        /// </summary>
        public void printHashTable()
        {
            for (int i = 0; i < 11; i++)
            {
                if (hashTable[i] != null)
                {
                    hashTable[i].readAll();
                }
            }
        }
        /// <summary>
        /// Searches the hash table.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        public bool SearchHashTable(int x)
        {
            int index = hashCode(x);
            if (hashTable[index] == null)
            {
                return false;
            }
            else
            {
                return hashTable[index].search(x);
            }
        }
        /// <summary>
        /// Gets all data.
        /// </summary>
        /// <returns></returns>
        public string getAllData()
        {
            string st = "";
            for (int i = 0; i < 11; i++)
            {
                if (hashTable[i] != null)
                {
                    st=st+hashTable[i].getLinkLis();
                }
            }
            return st;
        }
        /// <summary>
        /// Hashings the function form here we read from file and search and after all
        /// the list puit in file.
        /// </summary>
        public void HashingFunction()
        {
            string st = util.readFile("C://Users//Bridgelabz//source//repos//DataStructure//HashTable.txt");
            string[] str = st.Split(" ");
            // adding elements to hash table
            for (int i = 0; i <str.Length-1; i++)
            {
                addToHashTable(Convert.ToInt32(str[i]));
            }
            Console.WriteLine("All Data In File Is: ");
            printHashTable();
            Console.WriteLine("Enter the Element do you want to search");
            int n = util.inputInteger();
            int index = hashCode(n);
            ////search the number if found the give true if not then false
            bool f = SearchHashTable(n);
            Console.WriteLine(f);
            if(f==true)
            {
                Console.WriteLine("Element found an deleted");
                hashTable[index].delete(n);
                Console.WriteLine("After removing");
                printHashTable();
                bool f2 = util.writeInFile("C://Users//Bridgelabz//source//repos//DataStructure//HashTable.txt", getAllData());
                if (f2 == true)
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
                Console.WriteLine("Element Not Found so it will be added in the list");
                addToHashTable(n);
                printHashTable();
                bool f1 = util.writeInFile("C://Users//Bridgelabz//source//repos//DataStructure//HashTable.txt", getAllData());
                if (f1 == true)
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