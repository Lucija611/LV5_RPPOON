using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_L
{
    public class ConsoleLogger
    {
        private static ConsoleLogger instance;
        private ConsoleLogger() { }

        public static ConsoleLogger GetInstance()
        {
            if (instance == null)
            {
                instance = new ConsoleLogger();
            }

            return instance;
        }

        public void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}");
        }
    }
}
