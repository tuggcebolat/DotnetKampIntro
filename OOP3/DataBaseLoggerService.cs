﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DataBaseLoggerService:ILoggerService   //ıloggerservice alternatifi
     {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }

     }
}
