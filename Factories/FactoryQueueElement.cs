using BotFactory.Common.Tools;
using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;

namespace BotFactory.Factories
{
    public class FactoryQueueElement : IFactoryQueueElement
    {

        private string name;
        private Type model;
        private Coordinates parkingPos;
        private Coordinates workingPos;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                value = name;
            }
        }

        public Type Model
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

        public Coordinates ParkingPos
        {
            get
            {
                return parkingPos;
            }

            set
            {
                value = parkingPos;
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
                value = workingPos;
            }
        }

        public FactoryQueueElement()
        {
        }
        
        public FactoryQueueElement(string _Name,Type _Model,Coordinates _ParkingPos,Coordinates _WorkingPos)
        {
            Name = _Name;
            Model = _Model;
            ParkingPos = _ParkingPos;
            WorkingPos = _WorkingPos;
        }

    }
}
