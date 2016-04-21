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

        public WorkingUnit(double vitesse,double buildtime,string robotName,string model) : base(robotName,vitesse,buildtime)
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
