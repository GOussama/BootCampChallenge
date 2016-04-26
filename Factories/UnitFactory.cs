using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using BotFactory.Models;
using BotFactory.Interface;
using System.Threading;

namespace BotFactory.Factories
{
    public class UnitFactory
    {
        public int queueCapacity;
        public int storageCapacity;
        public static List<FactoryQueueElement> Queue = new List<FactoryQueueElement>();
        public static List<ITestingUnit> Storage = new List<ITestingUnit>();

        public UnitFactory(int _QueueCapacity,int _StorageCapacity)
        {
            queueCapacity = _QueueCapacity;
            storageCapacity = _StorageCapacity;
        }

        public UnitFactory()
        {
        }

        
        public void ConstructingUnitAndAddToStorage()
        {
            
                while(Queue.Count != 0)
            {
               
                Object activ = Activator.CreateInstance(Queue[0].Model);

                double _buildTime = ((WorkingUnit)activ).buildTime;
                bool _isWorking = ((WorkingUnit)activ).isWorking;
                string _model = Queue[0].Model.Name;
                string _name = Queue[0].Name;
                double _speed = ((WorkingUnit)activ).Speed;
                Coordinates _parkingPos = Queue[0].ParkingPos;
                Coordinates _workingPos = Queue[0].WorkingPos;
                Thread.Sleep(TimeSpan.FromSeconds(_buildTime));

                Storage.Add(new TestingUnit(_buildTime, _isWorking, _model, _name, _speed, _parkingPos, _workingPos));
                Queue.Remove(Queue[0]);
            }

        }
        
        public void AddWorkableUnitToQueue(Type model, string name, Coordinates parkingPos,
        Coordinates workingPos)
        {
            FactoryQueueElement nesfqe = new FactoryQueueElement();

            nesfqe.Model = model;
            nesfqe.Name = name;
            nesfqe.ParkingPos = parkingPos;
            nesfqe.WorkingPos = workingPos;

                if (Queue.Count < queueCapacity)
                {
                    Queue.Add(nesfqe);
                }
            
        }

    }
}
