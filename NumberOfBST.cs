// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NumberOfBST.cs" company="Bridgelabz">
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
    /// NumberOfBST is class to find how many number of bst tree can be formed
    /// </summary>
    class NumberOfBST
    {
        /// <summary>
        /// Calculations the BST.
        /// </summary>
        /// <param name="arr">The arr.</param>
        public void calculationBST(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                int r = claculate(arr[i]);
                Console.WriteLine(r);
            }
        }
        /// <summary>
        /// Claculates the specified n by using formula NumberOfBST=((2n!)/(n-1)!*n!).
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public int claculate(int n)
        {
            int numerator = factorial(2 * n);
            int denominator1 = factorial(n+1);
            int denominator2 = factorial(n);
            return (numerator) / (denominator1 * denominator2);
        }
        /// <summary>
        /// Factorials the specified n.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public int factorial(int n)
        {
            int f = 1;
            while(n>=1)
            {
                f = f * n;
                n--;
            }
            return f;
        }
    }
}