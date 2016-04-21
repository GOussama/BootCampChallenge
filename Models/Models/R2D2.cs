using BotFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public class R2D2 : WorkingUnit
    {
        public R2D2(double vitesse, double buildtimd) : base(vitesse,buildtimd,"HAL","HAL")
        {
        }

    }
}
