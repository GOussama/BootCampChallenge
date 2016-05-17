using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Interfaces
{
    public interface ITestingUnit : IBaseUnit,IBuildableUnit,IWorkingUnit
    {

        event EventHandler UnitStatusChanged;

       

        Task<Boolean> WorkBegins();
        Task<Boolean> WorkEnds();
    }
}
