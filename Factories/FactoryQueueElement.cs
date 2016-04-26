using BotFactory.Common.Tools;
using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Factories
{
    public class FactoryQueueElement
    {

        public string Name;
        public Type Model;
        public Coordinates ParkingPos;
        public Coordinates WorkingPos;

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
