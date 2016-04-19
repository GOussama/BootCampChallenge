using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;


namespace BotFactory.Interface
{
    public interface IReportingUnit
    {
        void UnitStatusChanged();
        void OnStatusChanged(IStatusChangedEventArgs scea);
        void AddWorkableUnitToQueue(string model, string name, Coordinates parkingPos,
        Coordinates workingPos);
    }
}
