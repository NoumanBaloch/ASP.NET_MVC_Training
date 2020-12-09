using System;

namespace SOLID.OpenClosedPrincipal
{
    public class ConsoleLogger : IMessageLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

}
