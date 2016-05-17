using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BotFactory.Common.Interfaces
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
