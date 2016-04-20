using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace BotFactory.Models
{
    public abstract class BaseUnit 
    {

        public string CurrentPos;

        public BaseUnit(string _robotName, double _robotSpeed = 1)
        {
            robotName = _robotName;
            robotSpeed = _robotSpeed;
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

        public string robotName;
        public Double robotSpeed;
               
        public Double Speed
        {
            get
            {
                return robotSpeed;
            }
            set
            {
                robotSpeed = value;
            }
        } 

        public string Name
        {
            get
            {
                return robotName;
            }
            set
            {
                robotName = value;
            }
        }
    }
}
