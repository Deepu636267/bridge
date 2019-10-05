// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TemperatureConversion.cs" company="Bridgelabz">
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
    /// TemperatureConversion is class for converting temprature Degree celciu to farenhite And vice versa.
    /// </summary>
    class TemperatureConversion
    {
        Utility util = new Utility();
        /// <summary>
        /// Converters this instance.
        /// </summary>
        public void converter()
        {
            Console.WriteLine("1.For Converting Degree Celcius to Farenhite,\n2. For Farenhite to Degree Celcius");
            int choose = util.inputInteger();
            ////switch() is used for operation performed by choice of user
            switch(choose)
            {
                case 1:
                    Console.WriteLine("Converting Degree Celcius to Farenhite Operation to be performed :");
                    Console.WriteLine("\nEnter the Temprature in Degree Celcius");
                    int C = util.inputInteger();
                    util.DC2F(C);
                    break;
                case 2:
                    Console.WriteLine(" Converting Farenhite to Degree Celcius Operation to be performed");
                    Console.WriteLine("\nEnter the Temprature in Farenhite");
                    int F = util.inputInteger();
                    util.F2C(F);
                    break;
            }
        }
    }
}