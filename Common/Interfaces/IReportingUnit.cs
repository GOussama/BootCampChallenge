﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BotFactory.Common.Interfaces
{
    public interface IReportingUnit
    {
        event EventHandler<IStatusChangedEventArgs> UnitStatusChanged;
      
        void OnStatusChanged(IStatusChangedEventArgs scea);

         int QueueFreeSlots
        {
            get;
            set;
        }
         int StorageFreeSlots
        {
            get;
            set;
        }
    }
}
