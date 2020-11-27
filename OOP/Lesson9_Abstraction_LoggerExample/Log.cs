﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Abstraction_LoggerExample
{

    public enum LogType {Error, Info, Warning, Verbose};

    public class Log
    {

        public Log()
        {
            Reviewed = false;
        }

        public Guid Id { get; set; } // 8624D714-793D-4813-A3EB-FFE8B03B3506 
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string WhereItHappened { get; set; }

        public bool Reviewed { get; set; }

        public LogType Type { get; set; }


    }
}
