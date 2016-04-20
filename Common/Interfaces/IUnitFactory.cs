using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace Common
{
    interface IUnitFactory
    {
        void AddWorkableUnitToQueue(string model, string name, Coordinates parkingPos,
        Coordinates workingPos);
    }
}
