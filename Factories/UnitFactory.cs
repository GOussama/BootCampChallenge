using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Factories
{
    public class UnitFactory
    {
        public int QueueCapacity;
        public int StorageCapacity;

        public UnitFactory(int _QueueCapacity,int _StorageCapacity)
        {
            QueueCapacity = _QueueCapacity;
            StorageCapacity = _StorageCapacity;
        }
    }
}
