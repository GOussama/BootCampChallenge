﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BotFactory.Common.Tools
{
    public class Vector
    {
        public Double x;
        public Double y;

        public Double X { get; set; }
        public Double Y { get; set; }

        public Vector()
        {
        }

        public Vector(Double x, Double y)
        {
            X = x;
            Y = y;
        }

        public static Vector FromCoordinates(Coordinates begin, Coordinates end)
        {

            Vector v = new Vector();
            v.X = end.X - begin.X;
            v.Y = end.Y - begin.Y;

            return v;
        }
       

        public Double Length()
        {
           Double x2 = Math.Pow(this.x, 2);
           Double y2 = Math.Pow(this.y, 2);

            return Math.Sqrt(x2 + y2); ;
        }
    }
}
