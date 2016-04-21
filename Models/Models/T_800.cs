using BotFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public class T_800 : WorkingUnit
    {
        public T_800(double vitesse, int buildtimd) : base(vitesse,buildtimd,"HAL","HAL")
        {
        }

    }
}
