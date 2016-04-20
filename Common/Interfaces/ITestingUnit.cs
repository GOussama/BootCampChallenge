using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Interface
{
    public interface ITestingUnit
    {

        IBaseUnit ibu
        {
            get;
            set;
        }
        IBuildableUnit ib
        {
            get;
            set;
        }
        IEventArgs iev
        {
            get;
            set;
        }
        IReportingUnit iru
        {
            get;
            set;
        }
        IStatusChangedEventArgs iscea
        {
            get;
            set;
        }


    }
}
