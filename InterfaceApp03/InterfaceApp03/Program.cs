using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp03
{
    interface iLogger
    {
        void WriteLog(string message);
    }
    class ConsoleLogger : iLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} {message}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            iLogger logger = new ConsoleLogger();
            logger.WriteLog("Hello World");
        }
    }
}
