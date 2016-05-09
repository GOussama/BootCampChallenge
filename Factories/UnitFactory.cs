using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using BotFactory.Models;
using BotFactory.Interface;
using System.Threading;
using BotFactory.Factories;

namespace BotFactory.Factories
{
    public class UnitFactory : ReportingFactory
    {

        public int queueCapacity;
        public int storageCapacity;
        public static List<FactoryQueueElement> Queue = new List<FactoryQueueElement>();
        public static List<ITestingUnit> Storage = new List<ITestingUnit>();

        public UnitFactory(int _QueueCapacity, int _StorageCapacity)
        {
            queueCapacity = _QueueCapacity;
            storageCapacity = _StorageCapacity;
        }

        public UnitFactory()
        {
        }

        public override void OnStatusChanged(IStatusChangedEventArgs scea)
        {
            base.OnStatusChanged(scea);

        }

        public void ConstructingUnitAndAddToStorage()
        {

            Console.Write("Construction en cours");
            OnStatusChanged(new StatusChangedEventArgs("Starting construction of robots", Queue[0], null));

            if (Storage.Count < Storage.Capacity) {

                while (Queue.Count != 0)
                {
                    var thread = new Thread(() =>
                    {

                        Object activ = Activator.CreateInstance(Queue[0].Model);

                        double _buildTime = ((WorkingUnit)activ).buildTime;
                        bool _isWorking = ((WorkingUnit)activ).isWorking;
                        string _model = Queue[0].Model.Name;
                        string _name = Queue[0].Name;
                        double _speed = ((WorkingUnit)activ).Speed;

                        Coordinates _parkingPos = Queue[0].ParkingPos;
                        Coordinates _workingPos = Queue[0].WorkingPos;

                        Console.WriteLine("Construction of the thread..., it takes :" + _buildTime);
                        Thread.Sleep(TimeSpan.FromSeconds(_buildTime));
                        Console.WriteLine("End of construction");
                        TestingUnit unit = new TestingUnit(_buildTime, _isWorking, _model, _name, _speed, _parkingPos, _workingPos);

                        Console.WriteLine("Adding unit to storage");
                        Storage.Add(unit);
                        Console.WriteLine("Unit " + unit.name + " added to storage");

                        Queue.Remove(Queue[0]);
                        OnStatusChanged(new StatusChangedEventArgs("Starting construction of robots",null, unit));

                    });

                    thread.Start();
                }
                OnStatusChanged(new StatusChangedEventArgs("Construction of robots is done", Queue[0], null));
                Console.Write("End of construction");
            }

            else
            {
                Console.Write("We cannot add any robot storage is full");
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

            if (Queue.Count < queueCapacity && Storage.Count < storageCapacity)
            {
                Queue.Add(nesfqe);
                Console.WriteLine("L'unité est ajouté à la queue");
            }
            else
            {
                Console.WriteLine("L'unité ne peut pas être ajouté car il ne reste plus de place");
            }

        }

    }
}
