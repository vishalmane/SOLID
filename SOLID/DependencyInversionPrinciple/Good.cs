using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversionPrinciple.Good
{
    public interface ILogger
    {
        void Log();
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            //Log to File
        }
    }
    class DbLogger : ILogger
    {
        public void Log()
        {
            //Log to DB
        }
    }
    class Program
    {
        ILogger logger;

        public Program(ILogger logger)
        {
            this.logger = logger;
        }

        public void DoWork()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                logger.Log();
            }
        }
    }
}
