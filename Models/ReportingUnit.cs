using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using BotFactory.Factories;

namespace BotFactory.Models
{
    class  ReportingUnit : BuildableUnit
    {

        


        private ReportingUnit() : base(5,"RG45")
        {

        }

        public void UnitStatusChanged()
        {


        }

        public void OnStatusChanged(StatusChangedEventArgs scea)
        {

            UnitStatusChanged();
        }

        static public void AddWorkableUnitToQueue(string model, string name, Coordinates parkingPos,
        Coordinates workingPos)
        {

            

        }

    }
}
