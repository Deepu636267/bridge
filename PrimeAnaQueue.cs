// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PrimeAnaQueue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sachin Kumar Maurya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// PrimeAnaQueue is a class for finding angram which are Prime by involvement of Queue
    /// operation using through linked list
    /// </summary>
    class PrimeAnaQueue
    {
        Utility util = new Utility();
        QueueLInkedList<int> List =new  QueueLInkedList<int>();
        /// <summary>
        /// Findings the prime number and store in to the list.
        /// </summary>
        public void findingPA()
        {
            ArrayList alist = new ArrayList();
            for(int i=2;i<=1000;i++)
            {
                if(util.prime(i))
                {
                    alist.Add(i);
                }
            }
            ////Finding the anagram
            for(int i=0;i<alist.Count;i++)
            {
                ////(int)ar[i]=type casting because ar[i] is a objct type 
                ///so we are not give object type refrenceto instance of object
                int f = (int)alist[i];
                for(int j=i+1;j<alist.Count;j++)
                {
                    int f1 = (int)alist[j];
                    if(util.anagram(f,f1))
                    {
                        List.enQueue(f);
                        List.enQueue(f1);
                    }
                }
            }
            ////Dequeue the list and print by using m,ethod in Linked List class
            while(List.total()!=0)
            {
                List.dequeue();
            }
        }
    }
}