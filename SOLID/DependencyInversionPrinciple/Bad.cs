using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DependencyInversionPrinciple.Bad
{
    class FileLogger
    {
        public void Log()
        {
            //Log to File
        }
    }
    class DbLogger
    {
        public void Log()
        {
            //Log to DB
        }
    }
    class Program
    {
        string WhereToLog;

        public Program(string whereToLog)
        {
            WhereToLog = whereToLog;
        }

        public void DoWork()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                if (WhereToLog == "File")
                {
                    var FileLogger = new FileLogger();
                    FileLogger.Log();
                }
                else
                {
                    var dbLogger = new DbLogger();
                    dbLogger.Log();
                }
            }

          
        }
    }
}
