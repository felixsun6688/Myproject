namespace FourWallsInterview
{
    /// <summary>
    /// This interface is designed to perform a logging function
    /// </summary>
    public interface IMessageLogger
    {
        /// <summary>
        /// This method is designed to log the sent message
        /// </summary>
        /// <param name="message">Message</param>
        /// <returns>True: log success, False: log failed</returns>
        bool Log(string message);
    }
}
