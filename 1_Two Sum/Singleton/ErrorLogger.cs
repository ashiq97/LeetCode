using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.Singleton
{
    internal class ErrorLogger
    {
        private static  ErrorLogger _logger;
        private ErrorLogger()
        {

        }
        public static ErrorLogger GetLogger()
        {
            if (_logger == null)
                _logger = new ErrorLogger();

            return _logger;
        }
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
