// --------------------------------------------------------------------------------------------------------------------
// <copyright file=MonthlyPayment.cs" company="Bridgelabz">
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
    /// MonthlyPayment class holds Payment method to clauclate the monthly pay for which is taking the loan
    /// </summary>
    class MonthlyPayment
    {
        Utility util = new Utility();
        public void payment()
        {
            Console.WriteLine("Enter the Principal Amount");
            double P = util.inputDouble();
            Console.WriteLine("Enter the Year");
            double Y = util.inputDouble();
            Console.WriteLine("Enter the Rate of Interest");
            double R = util.inputDouble();
            double n = 12 * Y;
            double r = R / (12 * 100);
            util.calculatePayment(P, n, r);
        }
    }
}