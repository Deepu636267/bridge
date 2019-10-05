// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SqrtNonNegative.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sachin Kumar Maurya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Algorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// SqrtNonNegative holds the method for finding square root
    /// </summary>
    class SqrtNonNegative
    {
        Utility util = new Utility();
        /// <summary>
        /// SQRTs this instance provinding inut and find square root with the help of util function in that method has been defined.
        /// </summary>
        public void sqrt()
        {
            Console.WriteLine("Enter th Non negative Number To calculate Sqrt");
            double c = util.inputDouble();
            if(c<=0)
            {
                Console.WriteLine("Enter the Positive Number");
            }
            else
            {
               double t= util.newtonsMethod(c);
                Console.WriteLine("Square root of " + c + " Non Negative Number is " + t);
            }
        }
    }
}