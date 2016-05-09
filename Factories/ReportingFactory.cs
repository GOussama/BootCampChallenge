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
        public event EventHandler UnitStatusChanged ;

        public virtual void OnStatusChanged(IStatusChangedEventArgs scea)
        {
            //UnitStatusChanged.Invoke(this,(StatusChangedEventArgs) scea);
            
            Console.Write("Now we " + scea.NewStatus); 
        }

        public ReportingFactory()
        {
        }

    }
}
