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
        public static List<FactoryQueueElement> Queue;
        public static List<ITestingUnit> Storage;

    }
}
