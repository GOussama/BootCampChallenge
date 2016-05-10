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

        private int queueCapacity;
        private int storageCapacity;
        public  List<FactoryQueueElement> queue;
        public  List<ITestingUnit> storage;

        public List<FactoryQueueElement> Queue
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


        public UnitFactory(int _QueueCapacity, int _StorageCapacity )
        {
            queueCapacity = _QueueCapacity;
            storageCapacity = _StorageCapacity;
            queue = new List<FactoryQueueElement>();
            storage = new List<ITestingUnit>();
        }

        public UnitFactory()
        {
        }

        private void constructionThread()
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

                    if ( queue.Count < storageCapacity - storage.Count && queue.Count < queueCapacity)
                    {
                        queue.Add(nesfqe);
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

