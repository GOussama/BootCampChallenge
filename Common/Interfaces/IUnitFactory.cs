using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace BotFactory.Common.Interfaces
{
    public interface IUnitFactory : IReportingFactory
    {
        event EventHandler FactoryProgress;
        void AddWorkableUnitToQueue(Type model, string name, Coordinates parkingPos,
        Coordinates workingPos);

        int QueueCapacity
        {
            get;
            set;
        }
        int StorageCapacity
        {
            get;
            set;
        }

        TimeSpan QueueTime
        {
            get;
            set;
        }

        List<IFactoryQueueElement> Queue
        {
            get;
            set;
        }

        List<ITestingUnit> Storage
        {
            get;
            set;
        }

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
