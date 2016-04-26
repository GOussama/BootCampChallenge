﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;

namespace BotFactory.Models
{
  public abstract class ReportingUnit : BuildableUnit, IReportingUnit
    {

        public int QueueFreeSlots;
        public int StorageFreeSlots;

        public ReportingUnit() : base()
        {
        }

        public ReportingUnit(double buildtime) : base(buildtime)
        {
        }

        public  void UnitStatusChanged()
        {
        }


        public void OnStatusChanged(IStatusChangedEventArgs scea)
        {
            throw new NotImplementedException();
        }
    }
}
