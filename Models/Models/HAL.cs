using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace BotFactory.Models
{
    public class HAL : WorkingUnit
    {
        public HAL(double vitesse, double buildtime,string name,Coordinates _ParkingPos, Coordinates _WorkingPos) : base(vitesse,buildtime,name,_ParkingPos,_WorkingPos)
        {
        }
        public HAL()
        {

        }
        public async new Task<Boolean> WorkBegins()
        {
            if(await base.WorkBegins())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async new Task<Boolean> WorkEnds()
        {
            if (await base.WorkBegins())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
