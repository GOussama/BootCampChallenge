﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using BotFactory.Models;

namespace BotFactory.Factories
{
    public class UnitFactory
    {
        public static int QueueCapacity;
        public static int StorageCapacity;
       


        public UnitFactory(int _QueueCapacity,int _StorageCapacity)
        {
            QueueCapacity = _QueueCapacity;
            StorageCapacity = _StorageCapacity;
        }

        static public void AddWorkableUnitToQueue(string model, string name, Coordinates parkingPos,
        Coordinates workingPos)
        {
             //FactoryQueueElement fqe = new FactoryQueueElement();

            if (FactoryQueueElement.Queue.Count < StorageCapacity)
            {

                if (UnitFactory.fqe.Queue.Count < QueueCapacity)
                {

                    

                }
            }
        }
    }
}
