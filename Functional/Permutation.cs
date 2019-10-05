// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Permutation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sachin Kumar Maurya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Functional
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Permutation
    {
        string result = "";
        Utility util = new Utility();
        public void permutateString()
        {
            string str = util.inputString();
          
         string ar= permutation(str.ToCharArray(), 0);
            string[] ar1 = ar.Split(" ");
            Console.WriteLine(ar1.Length);
          for(int i=0;i<ar.Length;i++)
            {
                Console.Write(ar[i]);
            }
        }
        public string permutation(char[] ch, int current)
        {
            
            if (current == ch.Length - 1)
            {
                string s = new string(ch);
                result = result + s + " ";
                // Console.WriteLine(ch);
            }
            for (int i = current; i < ch.Length; i++)
            {
                swap(ch, current, i);
             permutation(ch, current + 1);
                swap(ch, current, i);
            }
            return result;
        }
        public static void swap(char[] ch, int i, int j)
        {
            char temp = ch[i];
            ch[i] = ch[j];
            ch[j] = temp;
        }
    }
}