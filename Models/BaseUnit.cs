using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using BotFactory.Common.Tools;
using BotFactory.Common.Interfaces;

namespace BotFactory.Models
{
    public abstract class BaseUnit : ReportingUnit, IBaseUnit
    {

        public Coordinates currentPos;
        public string robotName;
        public double robotSpeed;

        public async Task<Boolean> WorkBegins(Coordinates _WorkingPos)
        {
            if (this.CurrentPos != _WorkingPos)
            {
                Console.WriteLine($"{DateTime.UtcNow} : Before moving");

                StatusChangedEventArgs scea_m = new StatusChangedEventArgs();
                scea_m.newStatus = "Moving to the working place";
                OnStatusChanged(scea_m);

                await this.Move(_WorkingPos.X, _WorkingPos.Y);

                Console.WriteLine($"{DateTime.UtcNow} : After moving");

                this.CurrentPos = _WorkingPos;

                StatusChangedEventArgs scea_a = new StatusChangedEventArgs();
                scea_a.newStatus = "Arriving to the working place";
                OnStatusChanged(scea_a);

                return true;
            }
            return false;
        }


        public async Task<Boolean> WorkEnds(Coordinates _ParkingPos)
        {
            if (this.CurrentPos != _ParkingPos)
            {
                Console.WriteLine($"{DateTime.UtcNow} : Before moving");

                StatusChangedEventArgs scea_m = new StatusChangedEventArgs();
                scea_m.newStatus = "Moving to the parking place";
                OnStatusChanged(scea_m);

                await this.Move(_ParkingPos.X, _ParkingPos.Y);
                Console.WriteLine($"{DateTime.UtcNow} : After moving");

                this.CurrentPos = _ParkingPos;

                StatusChangedEventArgs scea_a = new StatusChangedEventArgs();
                scea_a.newStatus = "Arriving to the parking place";
                OnStatusChanged(scea_a);

                return true;
            }

            return false;
        }

        public BaseUnit(string _robotName, double _robotSpeed, double buildtime) : base(buildtime)
        {

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

        public Coordinates CurrentPos
        {
            get
            {
                return currentPos;
            }

            set
            {
                currentPos = value;
            }
        }

        public async Task<Boolean> Move(Double X, Double Y)
        {

            Coordinates c = new Coordinates(X, Y);

            if (this.CurrentPos != c)
            {
                double parcourTime;
                Vector myParcVect = Vector.FromCoordinates(c, this.CurrentPos);
                parcourTime = robotSpeed * myParcVect.Length();
                Console.WriteLine($"{DateTime.UtcNow} :  before delay");
                await Task.Delay(TimeSpan.FromSeconds(parcourTime));
                Console.WriteLine($"{DateTime.UtcNow} :  after delay");
                this.CurrentPos = new Coordinates(X, Y);
                return true;
            }

            return false;

            /*Double DelaiExec;
            Stopwatch sw = Stopwatch.StartNew();
            sw.Stop();
            DelaiExec = sw.Elapsed.TotalMilliseconds;*/

        }
    }
}
