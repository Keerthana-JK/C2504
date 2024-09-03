using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Creational_DesignPattern
{
    internal class Program
    {
        // Adaptee class (legacy system)
        public class OldLogger
        {
            public void LogMessage(string message) //needs to be adapted
            {
                Console.WriteLine("Old Logger: " + message);
            }
        }

        // Target interface 
        public interface ILogger //interface that the client code expects to use
                                // = mobile
        {
            void Log(string message);
        }

        // Adapter class
        public class LoggerAdapter : ILogger //implements the `ILogger`
                                             //uses an instance of `OldLogger` to fulfill the `Log` method's requirement
                                             //translates the call from `Log` to `LogMessage`
        {
            private readonly OldLogger _oldLogger;

            public LoggerAdapter(OldLogger oldLogger)
            {
                _oldLogger = oldLogger;
            }

            public void Log(string message)
            {
                // Adapt the method call to the old logger's method
                _oldLogger.LogMessage(message);
            }
        }
        static void Main(string[] args)
        {
            // Existing client code expects ILogger interface
            ILogger logger = new LoggerAdapter(new OldLogger());
            logger.Log("This is a log message.");
        }
    }
}
