﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MailLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Maile loglandı");
        }
    }
}
