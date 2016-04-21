using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Models
{
    public class HAL : WorkingUnit
    {
        public HAL(double vitesse, int buildtimd) : base(vitesse,buildtimd,"HAL","HAL")
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
