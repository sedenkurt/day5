using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3DAy5
{
    class DataBaseLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }

        
    }
}
