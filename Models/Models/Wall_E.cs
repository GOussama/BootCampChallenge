﻿using BotFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;

namespace BotFactory.Models
{
    public class Wall_E : WorkingUnit
    {
        public Wall_E(double vitesse, double buildtimd, string name,Coordinates _ParkingPos,Coordinates _WorkingPos) : base(vitesse,buildtimd,name,_ParkingPos,_WorkingPos)
        {
        }

        public Wall_E()
        {

        }
        public async new Task<Boolean> WorkBegins()
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
