using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BotFactory.Models
{
  public class  ReportingUnit : BaseUnit
    {

        public ReportingUnit() : base("RG45",5)
        {
        }

        public  void UnitStatusChanged()
        {
        }

        public  void OnStatusChanged(StatusChangedEventArgs scea)
        {
            //UnitStatusChanged();
        }

        

    }
}
