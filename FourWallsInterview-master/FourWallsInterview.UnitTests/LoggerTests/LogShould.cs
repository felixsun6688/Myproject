using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace FourWallsInterview.UnitTests.LoggerTests
{
    public class LogShould
    {
        /// <summary>
        /// Please refactor FourWallsInterview.Logger and verify that the 
        /// Log method is being called correctly
        /// </summary>
        [Fact]
        public void Call_Log_with_message()
        {
            Mock<IMessageLogger> mockMessageLogger = new Mock<IMessageLogger>();
            mockMessageLogger.Setup(x => x.Log("Hello, world"));

            Logger logger = new Logger(mockMessageLogger.Object);            
           
            bool result =  logger.Log("Hello, world");
            bool expected = true;

            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Test ConsoleLogger's log method.
        /// </summary>
        [Fact]
        public void Call_Log_with_message_use_ConsoleLogger()
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            bool result = consoleLogger.Log("Hello, world");
            bool expected = true;

            Assert.Equal(expected, result);
        }

        /// <summary>
        /// Test QueueLogger's log method.
        /// </summary>
        [Fact]
        public void Call_Log_with_message_use_QueueLogger()
        {
            QueueLogger queueLogger = new QueueLogger();
            bool result = queueLogger.Log("Hello, world");
            bool expected = true;

            Assert.Equal(expected, result);
        }
    }
}
