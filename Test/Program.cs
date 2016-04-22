using BotFactory.Factories;
using BotFactory.Models;
using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            HAL hal01 = new HAL(0.5,7,"HAL","HAL",new Coordinates(0,0),new Coordinates(5,5));
            R2D2 r2d201 = new R2D2(1.5,5.5,"R2D2","R2D2",new Coordinates(0, 0),new Coordinates(5,5));
            T_800 t80001 = new T_800(3,10);
            Wall_E walle01 = new Wall_E(2,4);

            int QueueCapacity = 10;
            int StorageCapacity = 15;

            UnitFactory unitFactory = new UnitFactory(QueueCapacity,StorageCapacity);
            unitFactory.AddWorkableUnitToQueue(hal01.Model, hal01.Name, hal01.ParkingPos, hal01.WorkingPos);




        }
    }
}
