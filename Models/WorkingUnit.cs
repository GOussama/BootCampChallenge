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

        public Coordinates ParkingPos;
        public Coordinates WorkingPos;
        public bool IsWorking;

        Coordinates IWorkingUnit.ParkingPos
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        Coordinates IWorkingUnit.WorkingPos
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        bool IWorkingUnit.IsWorking
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public WorkingUnit():base()
        {

        }

        public WorkingUnit(double vitesse,double buildtime,string robotName,string model,Coordinates ParkingPos,Coordinates WorkingPos) : base(robotName,vitesse,buildtime,model)
        {

        }

        public async Task<Boolean> WorkBegins()
        {
            if (await WorkBegins(this.WorkingPos))
            {
                IsWorking = true; 
                return true;
            }
            return false;
        }

        public async Task<Boolean> WorkEnds()
        {
            if (await WorkEnds(this.ParkingPos))
            {
                IsWorking = false;
                return true;
            }
            return false;
        }
       
    }
}
