// --------------------------------------------------------------------------------------------------------------------
// <copyright file=GuessGame.cs" company="Bridgelabz">
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
    /// GuessGame is class for play the guess game
    /// </summary>
    class GuessGame
    {
        Utility util = new Utility();
        public void find()
        {
               int low = 0, high = 1000, mid;
                while (low != high)
                {
                    mid = (low + high) / 2;
                    ////Asking the question from user
                    Console.WriteLine("enter 1 if no is between " + low + " - " + mid + "\nEnter 2 if no is between "
                            + (mid + 1) + " - " + high);
                    int c = util.inputInteger();
                    mid = (low + high) / 2;
                    if (c == 1)
                        high = mid;
                    else
                        low = mid + 1;
                }
            Console.WriteLine("Guessed Number is: " + low);
        }
    }
}