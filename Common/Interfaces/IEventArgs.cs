﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Interface
{
    public interface IEventArgs
    {  
         string NewStatus
        {
            get;
            set;
        }
    }
}