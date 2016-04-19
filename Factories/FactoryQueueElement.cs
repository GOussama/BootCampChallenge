using BotFactory.Common.Tools;
using BotFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Factories
{
    class FactoryQueueElement
    {
        public string Name;
        public Type Model;
        public Coordinates ParkingPos;
        public Coordinates WorkingPos;
        public List<FactoryQueueElement> Queue;
        public List<ITestingUnit> Storage;

    }
}
