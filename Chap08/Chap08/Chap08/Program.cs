using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap08
{
    interface ILogger
    {
        void WriteLog(string msg);
    }

    class consoleLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"{DateTime.Now} log : {msg}");
        }
    }

    class customLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"Log : {msg}\a");
        }
    }

    class ClimateLogger 
    {
        private ILogger logger;
        public ClimateLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력 : ");
                string temp = Console.ReadLine(); //
                if (string.IsNullOrEmpty(temp)) break;

                logger.WriteLog($"현재 온도 : {temp} ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new consoleLogger();
            logger.WriteLog("로그출력!");

            ClimateLogger clogger = new ClimateLogger(new customLogger());
            clogger.start(); //IoC (제어의 역전(흐름) )
        }
    }
}
