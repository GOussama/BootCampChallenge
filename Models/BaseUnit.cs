using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using BotFactory.Common.Tools;

namespace BotFactory.Models
{
    public abstract class BaseUnit : BuildableUnit
    {

        public string CurrentPos;

        public BaseUnit(string _name, double _speed = 1):base(5.00) 
        {
            name = _name;
            speed = _speed;
        }

        public async Task<Boolean> Move(Double X, Double Y)
        {

            await Task.Delay(10000);
            
            /*
            Double tempParc = 0;
            tempParc = this.speed / Y-X ;
            
            Double DelaiExec;
            Stopwatch sw = Stopwatch.StartNew();
           
            sw.Stop();
            DelaiExec = sw.Elapsed.TotalMilliseconds;
            */

            return true;
        }

        public string name;
        public Double speed;
               
        public Double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        } 

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
