using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Common.Interfaces
{
    public interface IBaseUnit
    {
         Double Speed
        {
            get;
            set;
        }

         string Name
        {
            get;
            set;    
        }

        Coordinates CurrentPos
        {
            get;
            set;
        }
    }
}
