using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using BotFactory.Interface;

namespace BotFactory.Models
{
  public abstract class ReportingUnit : BuildableUnit, IReportingUnit
    {

        int QueueFreeSlots;
        int StorageFreeSlots;

        public ReportingUnit() : base()
        {
        }

        public ReportingUnit(double buildtime) : base(buildtime)
        {
        }

        public  void UnitStatusChanged()
        {
        }

        public  void OnStatusChanged(StatusChangedEventArgs scea)
        {
            //UnitStatusChanged();
        }

        public void OnStatusChanged(IStatusChangedEventArgs scea)
        {
            throw new NotImplementedException();
        }
    }
}
