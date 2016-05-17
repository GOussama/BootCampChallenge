using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotFactory.Common.Tools;
using BotFactory.Models;
using System.Threading;
using BotFactory.Factories;
using BotFactory.Common.Interfaces;

namespace BotFactory.Factories
{
    public class UnitFactory : ReportingUnit, IUnitFactory
    {

        private int queueCapacity;
        private int storageCapacity;
        private TimeSpan queueTime;
        public List<IFactoryQueueElement> queue;
        public List<ITestingUnit> storage;
        private Object thisLock = new Object();
        public event EventHandler FactoryProgress;

        public List<IFactoryQueueElement> Queue
        {
            get
            {
                return queue;
            }
            set
            {
                queue = value;
            }
        }

        public List<ITestingUnit> Storage
        {
            get
            {
                return storage;
            }
            set
            {
                storage = value;
            }
        }

        public int QueueCapacity
        {
            get
            {
                return queueCapacity;
            }
            set
            {
                queueCapacity = value;
            }
        }


        public int StorageCapacity
        {
            get
            {
                return storageCapacity;
            }
            set
            {
                storageCapacity = value;
            }

        }

        public TimeSpan QueueTime
        {
            get
            {
                return queueTime;
            }

            set
            {
                queueTime = value;
            }
        }

        public UnitFactory(int _QueueCapacity, int _StorageCapacity)
        {
            queueCapacity = _QueueCapacity;
            storageCapacity = _StorageCapacity;
            queue = new List<IFactoryQueueElement>();
            //storage = new List<ITestableUnit();
            storage = new List<ITestingUnit>();
        }

        public UnitFactory()
        {
        }

        private void constructionThread()
        {
            lock (thisLock)
            {
                int lastElementIndex = queue.Count - 1;
                while (queue.Count != 0)
                {
                    Object activ = Activator.CreateInstance(queue[0].Model);

                    double _buildTime = ((WorkingUnit)activ).BuildTime;
                    bool _isWorking = ((WorkingUnit)activ).isWorking;
                    string _model = queue[0].Model.Name;
                    string _name = queue[0].Name;
                    double _speed = ((WorkingUnit)activ).Speed;

                    Coordinates _parkingPos = queue[0].ParkingPos;
                    Coordinates _workingPos = queue[0].WorkingPos;

                    OnStatusChanged(new StatusChangedEventArgs("Starting construction of robots ", queue[0], null));
                    
                    Console.WriteLine("Construction of the unit..., it takes :" + _buildTime);
                    Thread.Sleep(TimeSpan.FromSeconds(_buildTime));

                    Console.WriteLine("End of construction");
                    TestingUnit unit = new TestingUnit(_buildTime, _isWorking, _model, _name, _speed, _parkingPos, _workingPos);

                    Console.WriteLine("Adding unit to storage");
                    storage.Add(unit);

                    Console.WriteLine("Unit " + unit.name + " added to storage");
                    queue.Remove(queue[0]);
                    Console.WriteLine("unit removed from the queue");

                    OnStatusChanged(new StatusChangedEventArgs("Adding the unit to the storage ", null, unit));

                }
            }
        }

        /*
                private void ConstructingUnitAndAddToStorage()
                {
                    Console.Write("Construction en cours");
                    //OnStatusChanged(new StatusChangedEventArgs("Starting construction of robots", queue[0], null));
                    if (storage.Count < queueCapacity)
                    {
                        Thread thread = new Thread(() =>
                        {
                            while (queue.Count != 0)
                            {
                                Object activ = Activator.CreateInstance(queue[0].Model);
                                double _buildTime = ((WorkingUnit)activ).BuildTime;
                                bool _isWorking = ((WorkingUnit)activ).isWorking;
                                string _model = queue[0].Model.Name;
                                string _name = queue[0].Name;
                                double _speed = ((WorkingUnit)activ).Speed;
                                Coordinates _parkingPos = queue[0].ParkingPos;
                                Coordinates _workingPos = queue[0].WorkingPos;
                                Console.WriteLine("Construction of the thread..., it takes :" + _buildTime);
                                Thread.Sleep(TimeSpan.FromSeconds(_buildTime));
                                Console.WriteLine("End of construction");
                                TestingUnit unit = new TestingUnit(_buildTime, _isWorking, _model, _name, _speed, _parkingPos, _workingPos);
                                Console.WriteLine("Adding unit to storage");
                                storage.Add(unit);
                                Console.WriteLine("Unit " + unit.name + " added to storage");
                                queue.Remove(queue[0]);
                                //OnStatusChanged(new StatusChangedEventArgs("Starting construction of robots", null, unit));
                            }
                        });

                        thread.Name = "machine";
                        thread.Start();

                        //OnStatusChanged(new StatusChangedEventArgs("Construction of robots is done", queue[0], null));
                        Console.WriteLine("End of construction");
                    }
                    else
                    {
                        Console.Write("We cannot add any robot,  storage is full");
                    }
                }
        */

        public void AddWorkableUnitToQueue(Type model, string name, Coordinates parkingPos,
        Coordinates workingPos)
        {

            FactoryQueueElement nesfqe = new FactoryQueueElement();

            nesfqe.Model = model;
            nesfqe.Name = name;
            nesfqe.ParkingPos = parkingPos;
            nesfqe.WorkingPos = workingPos;

            if (queue.Count < storageCapacity - storage.Count && queue.Count < queueCapacity)
            {
                queue.Add(nesfqe);
                OnStatusChanged(new StatusChangedEventArgs("Adding the unit to the queue ", null, null));
                Console.WriteLine("L'unité est ajouté à la queue");
                //ConstructingUnitAndAddToStorage();
                Thread thread = new Thread(constructionThread);
                thread.Start();
            }
            else
            {
                Console.WriteLine("L'unité ne peut pas être ajouté car il ne reste plus de place");
            }

        }
    }

}

