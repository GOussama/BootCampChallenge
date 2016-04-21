using BotFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public class Wall_E : WorkingUnit
    {
        public Wall_E(double vitesse, int buildtimd) : base(vitesse,buildtimd,"HAL","HAL")
        {
        }
    }
}
