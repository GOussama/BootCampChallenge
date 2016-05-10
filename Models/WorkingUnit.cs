using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using BotFactory.Interface;

namespace BotFactory.Models
{
   public abstract class WorkingUnit : BaseUnit, IWorkingUnit
    {

        public Coordinates parkingPos;
        public Coordinates workingPos;
        public bool isWorking;

        public WorkingUnit() : base()
        {
        }

        public WorkingUnit(double vitesse, double buildtime, string robotName, Coordinates _ParkingPos, Coordinates _WorkingPos) : base(robotName, vitesse, buildtime)
        {
            parkingPos = _ParkingPos;
            workingPos = _WorkingPos;
        }

        public async Task<Boolean> WorkBegins()
        {
            if (await WorkBegins(this.workingPos))
            {
                isWorking = true;
                return true;
            }
            return false;
        }

        public async Task<Boolean> WorkEnds()
        {
            if (await WorkEnds(this.parkingPos))
            {
                isWorking = false;
                return true;
            }
            return false;
        }

        public Coordinates ParkingPos
        {
            get
            {
                return parkingPos;
            }
            set
            {
                parkingPos = value;
            }
        }


        public Coordinates WorkingPos
        {
            get
            {
                return workingPos;
            }
            set
            {
                workingPos = value;
            }
        }


       public bool IsWorking
        {
            get
            {
                return isWorking;
            }
            set
            {
                isWorking = value;
            }
        } 
    }
}
