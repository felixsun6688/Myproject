namespace FourWallsInterview
{
    /// <summary>
    /// This class is designed to perform a logging function using printer
    /// </summary>
    public class QueueLogger : IMessageLogger
    {
        /// <summary>
        /// This method is designed to send message to printer
        /// </summary>
        /// <param name="message">Message</param>
        /// <returns>True: log success, False: log failed</returns>
        public bool Log(string message)
        {
            // Code to send message to printer
            return true;
        }
    }
}
