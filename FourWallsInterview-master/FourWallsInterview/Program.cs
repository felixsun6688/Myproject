using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWallsInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = null;

            // Create a ConsoleLogger object
            IMessageLogger consoleLogger = new ConsoleLogger();
            // Create a Logger object
            logger = new Logger(consoleLogger);
            // Invoke log method
            logger.Log("Hello, world");

            // Create a QueueLogger object
            IMessageLogger queueLogger = new QueueLogger();
            // Create a Logger object
            logger = new Logger(queueLogger);
            // Invoke log method
            logger.Log("Hello, world");
        }
    } 
}


