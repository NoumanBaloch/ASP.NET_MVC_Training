using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosedPrincipal
{
    public class Logger
    {
        IMessageLogger _messageLogger;
        public Logger(IMessageLogger messageLogger)
        {
            _messageLogger = messageLogger;
        }

        public void Log(string message)
        {
            _messageLogger.Log(message);
        }
    }

}
