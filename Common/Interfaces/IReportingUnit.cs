using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BotFactory.Interface
{
    public interface IReportingUnit
    {
        event EventHandler  UnitStatusChanged;
        void OnStatusChanged(IStatusChangedEventArgs scea);
        
    }
}
