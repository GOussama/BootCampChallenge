using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;
using BotFactory.Models;

namespace BotFactory.Factories
{
    public abstract class  ReportingFactory : IReportingUnit

    {

        public event EventHandler<IStatusChangedEventArgs> UnitStatusChanged;
        //public delegate void EventHandler(object sender, EventArgs e);
        public virtual void OnStatusChanged(IStatusChangedEventArgs scea)
        {
            EventHandler<IStatusChangedEventArgs> handler = UnitStatusChanged;

            // Event will be null if there are no subscribers
            if (handler != null)
            {
                // Format the string to send inside the CustomEventArgs parameter
                scea.NewStatus += String.Format(" at {0}", DateTime.Now.ToString());
                // Use the () operator to raise the event.
                handler(this, scea);
            }
            /*
            UnitStatusChanged.Invoke(this,(StatusChangedEventArgs) scea);      
            Console.Write("Now we " + scea.NewStatus); 
            */
        }
        /*
        public ReportingFactory()
        {
            UnitStatusChanged+=
        }
        */
    }
}
