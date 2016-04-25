using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Models;
using BotFactory.Interface;

namespace BotFactory.Models
{
    public abstract class BuildableUnit : IBuildableUnit
    {

        public double buildTime = 5;
        public string model;
      

        public BuildableUnit()
        {
        }

        public BuildableUnit(Double _BuildTime)
        {
            this.buildTime = _BuildTime;
            this.model = this.GetType().Name;
        }


        double IBuildableUnit.BuildTime
        {
            get
            {
                return buildTime;
            }

            set
            {
                 buildTime = value;
            }
        }


        string IBuildableUnit.Model
        {
            get
            {
                return model;
            }

            set
            {
                value = model;
            }
        }
    }
}
