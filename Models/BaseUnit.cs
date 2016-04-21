using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using BotFactory.Interface;
using BotFactory.Common.Tools;

namespace BotFactory.Models
{
    public abstract class BaseUnit : ReportingUnit,IBaseUnit
    {
        public Coordinates CurrentPos;
        public string robotName;
        public double robotSpeed;

        public async Task<Boolean> WorkBegins(Coordinates _WorkingPos)
        {

            if (this.CurrentPos != _WorkingPos)
                return false;

            else {
                await Task.Delay(10000);
                return true;
            }   
        }

        public async Task<Boolean> WorkEnds()
        {
            await Task.Delay(10000);
            return true;
        }

        public BaseUnit(string _robotName,double _robotSpeed,double buildtime):base(buildtime)
        {
            //this.CurrentPos = _CurrentPos;
            this.robotName = _robotName;
            this.robotSpeed = _robotSpeed;
        }

        public BaseUnit() : base()
        {
            robotSpeed = 1;
            CurrentPos = new Coordinates(0, 0);
        }

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

        public async Task<Boolean> Move(Double X, Double Y)
        {

            double tempParcour;
            await Task.Delay(10000);
            if (this.CurrentPos != new Coordinates(X, Y))
            {
                this.CurrentPos = new Coordinates(X, Y);
            }
            /*Double tempParc = 0;
           tempParc = this.speed / Y-X ;
           Double DelaiExec;
           Stopwatch sw = Stopwatch.StartNew();
           sw.Stop();
           DelaiExec = sw.Elapsed.TotalMilliseconds;*/
            return true;
        }    
    }
}
