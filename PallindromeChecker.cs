﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=PallindromeChecker.cs" company="Bridgelabz">
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
    /// PallindromeChecker is a class to find the pallindrome 
    /// for the string
    /// </summary>
    class PallindromeChecker
    {
        Queue queue = new Queue();
        Utility util = new Utility();
        /// <summary>
        /// pallindrome() is a method to for all process .
        /// </summary>
        public void pallindrome()
        {
            ////Reading htrough the file
            Console.WriteLine("Enter the String That You WantTo check For Pallindrome");
            string s = util.inputString();
            char[] ch = s.ToCharArray();
            for(int i=0;i<ch.Length;i++)
            {
                ////adding in them 
                queue.addRear(ch[i]);
            }
            int flag = 0;
             queue.display();
            ////for taking the string out and check for palindrome in the pattern of FIFO
             while(queue.total()>1)
             {
                 if (queue.removeFront() != queue.removeRear())
                 {
                     flag = 1;
                     break;
                 }
               
             }
             if (flag == 0)
             {
                Console.WriteLine("String is palindrome");
             }
             else
             {
                 Console.WriteLine("String is not palindrome");
             }
        }
    }
}