using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Interfaces
{
    public interface IBuildableUnit
    {

        Double BuildTime
        {
            get;
            set;
        }

        string Model
        {
            get;
            set;
        }
    }
}
