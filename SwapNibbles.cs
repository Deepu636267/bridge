// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SwapNibbles.cs" company="Bridgelabz">
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
    /// SwapNibbles class is used for Swap b/w the half of Binary number
    /// </summary>
    class SwapNibbles
    {
        Utility util = new Utility();
        /// <summary>
        /// Swaps this instance.
        /// </summary>
        public void swap()
        {
            Console.WriteLine("Enter the Decimal number to convert in binary");
            int Num = util.inputInteger();
            int[] bin = util.convertBinary(Num);
            int[] decim = util.swapNibbles(bin);
            int deci = 0;
            Console.WriteLine("After Swapping th New Binary Representation is: ");
            for(int i=decim.Length-1;i>=0;i--)
            {
                Console.Write(decim[i]);
            }
            Console.WriteLine();
            Console.Write("After swap nibbles the new Number is :");
            for (int i = decim.Length - 1; i >= 0; i--)
            {
                if (decim[i] == 1)
                {
                    deci = deci + (int)Math.Pow(2, i);
                }
            }
            Console.Write(deci);
            Console.WriteLine();
            bool check = util.powerOf2(Num);
            if(check==true)
            {
                Console.WriteLine("It has a Power of Two");
            }
            else
            {
                Console.WriteLine("It has Not a Power Of Two");
            }
        }
    }
}