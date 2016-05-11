using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;

namespace BotFactory.Models
{
  public abstract class ReportingUnit : BuildableUnit, IReportingUnit
    {

        private int queueFreeSlots;
        private int storageFreeSlots;

        public int QueueFreeSlots
        {
            get
            {
                return queueFreeSlots;
            }
            set
            {
                value = queueFreeSlots;
            }
        }

        public int StorageFreeSlots
        {
            get
            {
                return storageFreeSlots;
            }
            set
            {
                value = storageFreeSlots;
            }
        }

        public ReportingUnit() : base()
        {
        }

        public ReportingUnit(double buildtime) : base(buildtime)
        {
        }

        public event EventHandler<IStatusChangedEventArgs> UnitStatusChanged;

        public virtual void OnStatusChanged(IStatusChangedEventArgs scea)
        {
            UnitStatusChanged.Invoke(this, (StatusChangedEventArgs)scea);
        }
    }
}
