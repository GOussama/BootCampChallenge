using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using Common.Interfaces;

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

        Coordinates IWorkingUnit.ParkingPos
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


        Coordinates IWorkingUnit.WorkingPos
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


        bool IWorkingUnit.IsWorking
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
