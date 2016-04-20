using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Models;

namespace BotFactory.Models
{
    public abstract class BuildableUnit : ReportingUnit
    {

        public double BuildTime = 5;
        public string Model;

        public BuildableUnit(Double _BuildTime, string _model)
        {
            this.BuildTime = _BuildTime;
            this.Model = _model;
        }

        
    

    }
}
