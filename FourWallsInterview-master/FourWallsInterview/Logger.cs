using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWallsInterview
{
    /// <summary>
    /// This class is designed to perform a basic logging function.
    /// In the future, we might want to expand our logging capabilities. 
    /// 
    /// Currently, this class doesn't follow SOLID and would require too much modification to extext. 
    /// It violates the Open Close Principle. 
    /// 
    /// Please refactor this method and provide tests in FourWallsInterview.UnitTests.LoggerTests.LogShould.
    /// 
    /// 
    /// Hint:
    /// 
    /// public class ConsoleLogger : IMessageLogger {}
    /// public class QueueLogger : IMessageLogger {}
    /// </summary>
    public class Logger
    {
        #region Private fields
        private IMessageLogger _messageLogger;
        #endregion

        #region Constructor
        public Logger(IMessageLogger messageLogger)
        {
            _messageLogger = messageLogger;
        }
        #endregion

        #region Public methods
        public bool Log(string message)
        {
            _messageLogger.Log(message);

            return true;
        }
        #endregion
    }
}
