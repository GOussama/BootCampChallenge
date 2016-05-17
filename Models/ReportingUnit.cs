using BotFactory.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
  public abstract class ReportingUnit : BuildableUnit, IReportingUnit
    {

        private int queueFreeSlots;
        private int storageFreeSlots;
        public event EventHandler<IStatusChangedEventArgs> UnitStatusChanged;


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

       

        public virtual void OnStatusChanged(IStatusChangedEventArgs scea)
        {
            EventHandler<IStatusChangedEventArgs> handler = UnitStatusChanged;
            // Event will be null if there are no subscribers

            if (handler != null)
            {
                // Format the string to send inside the CustomEventArgs parameter
                //scea.NewStatus += String.Format(" at {0}", DateTime.Now.ToString());
                Console.Write("Now we " + scea.NewStatus);
                // Use the () operator to raise the event.
                handler(this, scea);
            }
            /*
            UnitStatusChanged.Invoke(this,(StatusChangedEventArgs) scea);      
            Console.Write("Now we " + scea.NewStatus); 
            */
        }
    }
}
  
