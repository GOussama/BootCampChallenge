using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Interface;
using Common.Interfaces;

namespace BotFactory.Interface
{
    public interface IStatusChangedEventArgs
    {
        string NewStatus
        {
            get;
            set;
        }

        IFactoryQueueElement FirstQE
        {
            get;
            set;
        }

        ITestingUnit Testunit
        {
            get;
            set;
        }

    }
}
