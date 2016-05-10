using BotFactory.Factories;
using BotFactory.Models;
using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using BotFactory.Interface;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int QueueCapacity = 10;
            int StorageCapacity = 15;

            HAL hal01 = new HAL(0.5,7,"hal01",new Coordinates(0,0),new Coordinates(5,5));
            R2D2 r2d201 = new R2D2(1.5,5.5,"r2d201",new Coordinates(0,0),new Coordinates(5,5));
            T_800 t80001 = new T_800(3,10,"t80001",new Coordinates(0,0),new Coordinates(5,5));
            Wall_E walle01 = new Wall_E(2,4,"walle01",new Coordinates(0,0),new Coordinates(5,5));

            UnitFactory unitFactory = new UnitFactory(QueueCapacity,StorageCapacity);

            unitFactory.AddWorkableUnitToQueue(hal01.GetType(), hal01.Name, hal01.parkingPos, hal01.workingPos);
            unitFactory.AddWorkableUnitToQueue(r2d201.GetType(), r2d201.Name, r2d201.parkingPos, r2d201.workingPos);
            unitFactory.AddWorkableUnitToQueue(t80001.GetType(), t80001.Name, hal01.parkingPos, t80001.workingPos);
            unitFactory.AddWorkableUnitToQueue(walle01.GetType(), walle01.Name, walle01.parkingPos, walle01.workingPos);

        }
    }
}
