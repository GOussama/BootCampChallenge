using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace BotFactory.Models
{
    abstract class WorkingUnit : BaseUnit
    {

        Coordinates ParkingPos;
        Coordinates WorkingPos;
        bool IsWorking;

        public WorkingUnit():base("002",1)
        {

        }

        public async Task<Boolean> WorkBegins()
        {
            await Task.Delay(10000);
            return true;
        }

        public async Task<Boolean> WorkEnds()
        {
            await Task.Delay(10000);
            return true;
        }

       
    }
}
