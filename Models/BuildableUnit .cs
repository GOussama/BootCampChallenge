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

        public double BuildTime = 5;
        public string Model;

        public BuildableUnit()
        {
        }

        public BuildableUnit(Double _BuildTime,string _model)
        {
            this.BuildTime = _BuildTime;
            this.Model = _model;
        }

        double IBuildableUnit.BuildTime
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

        string IBuildableUnit.Model
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
    }
}
