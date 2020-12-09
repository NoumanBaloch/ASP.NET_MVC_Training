using System;
namespace SOLID.OpenClosedPrincipal
{
    public class FileLogger : IMessageLogger
    {
        public void Log(string message)
        {
            //Maybe we will log this in file
            Console.WriteLine("Hello From File Log");
        }
    }

}
