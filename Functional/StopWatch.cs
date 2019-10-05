// --------------------------------------------------------------------------------------------------------------------
// <copyright file=StopWatch.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sachin Kumar Maurya"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Functional
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class StopWatch
    {
        long startTimer;
        long stopTimer;
        long elapsed;
        /// <summary>
        /// Starts this instance start the stop watch.
        /// </summary>
        public void start()
        {
            startTimer = DateTime.Now.Millisecond; 
        }
        /// <summary>
        /// Stops this instance stop the stopwatch.
        /// </summary>
        public void stop()
        {
            stopTimer = DateTime.Now.Millisecond; 
        }
        /// <summary>
        /// Gets the elapsed time between start and stop.
        /// </summary>
        /// <returns></returns>
        public int getElapsedTime()
        {
            elapsed = stopTimer - startTimer;
            return (int)elapsed;
        }
    }
}