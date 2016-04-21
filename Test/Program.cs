using BotFactory.Models;
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

            HAL hal01 = new HAL(0.5, 7);
            R2D2 r2d201 = new R2D2(1.5, 5.5);
            T_800 t80001 = new T_800(3, 10);
            Wall_E walle01 = new Wall_E(2, 4);

            hal01.WorkBegins();



        }
    }
}
