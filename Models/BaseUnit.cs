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
            {
                await this.Move(_WorkingPos.X,_WorkingPos.Y);
                return true;
            }
            return false;  
        }

        public async Task<Boolean> WorkEnds(Coordinates _ParkingPos)
        {

            if (this.CurrentPos != _ParkingPos)
            {
                await this.Move(_ParkingPos.X, _ParkingPos.Y);
                return true;
            }
            return false;
        }

        public BaseUnit(string _robotName,double _robotSpeed,double buildtime,string model):base(buildtime,model)
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
            double parcourTime;
            Vector myParcVect = Vector.FromCoordinates(new Coordinates(X, Y),this.CurrentPos);
            parcourTime = robotSpeed * myParcVect.Length();         
            await Task.Delay(TimeSpan.FromSeconds(parcourTime));

            if (this.CurrentPos != new Coordinates(X,Y))
            {
                this.CurrentPos = new Coordinates(X,Y);
            }

            /*Double DelaiExec;
            Stopwatch sw = Stopwatch.StartNew();
            sw.Stop();
            DelaiExec = sw.Elapsed.TotalMilliseconds;*/

            return true;
        }    
    }
}
