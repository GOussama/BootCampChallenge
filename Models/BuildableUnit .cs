using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Models;
using BotFactory.Common.Interfaces;

namespace BotFactory.Models
{
    public abstract class BuildableUnit : IBuildableUnit
    {

        private double buildTime = 5;
        private string model;   

        public BuildableUnit()
        {
        }

        public BuildableUnit(Double _BuildTime)
        {
            this.buildTime = _BuildTime;
            this.model = this.GetType().Name;
        }


        public double BuildTime
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


        public string Model
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
