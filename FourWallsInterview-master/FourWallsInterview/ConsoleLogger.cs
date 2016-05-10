using System;

namespace FourWallsInterview
{
    /// <summary>
    /// This class is designed to perform a logging function on console
    /// </summary>
    public class ConsoleLogger : IMessageLogger
    {
        /// <summary>
        /// This method is designed to show message on console
        /// </summary>
        /// <param name="message">Message</param>
        /// <returns>True: log success, False: log failed</returns>
        public bool Log(string message)
        {
            Console.WriteLine(message);

            return true;
        }
    }
}
